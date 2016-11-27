// Compile with C89+ or C++03+

#include <stdio.h>
#include <string.h>
#include <stdlib.h>

typedef unsigned int uint;
typedef unsigned char byte;
typedef unsigned short ushort;

// sdbt extract-hex SaveDongle_vXX.bin extracted.bin
// sdbt build "Version Title" eng_desc.txt chi_desc.txt payload.bin output.bin
// sdbt make_debug_bin output.bin

// Chinese text uses encoding GB2312. (Or a superset of it?)

// SEEK_SET = 0, SEEK_CUR = 1, SEEK_END = 2

// total size is 44 bytes
typedef struct _HEX_INFO {
	uint offset_of_payload_description;

	uint payload_size;

	ushort is_enabled;

	char version_title[33 + 1];
} *PHEX_INFO, HEX_INFO;

const char constant_bin_format_version[8] = "v1.0";

typedef struct _HEX_HEADER {
	uint checksum; // the checksum of the file starting at the fifth byte

	uint g_number_of_versions;

	char bin_format_version[7 + 1]; // Unknown

	HEX_INFO hexinfo;

	char english_description[255 + 1];
	char chinese_gb2312_description[255 + 1];

	byte encryption_key[256];
} *PHEX_HEADER, HEX_HEADER;

#define SMALLEST_BIN_FILE (sizeof(HEX_HEADER) + 0x100)
#define LARGEST_BIN_FILE (sizeof(HEX_HEADER) + 0xfffe)

//static HEX_DESCRIPTION hexdescription[16];
//static HEX_INFO hexinfo[40];

void SimpleEncryptDecrypt(byte* data, byte* key, uint size)
{
	uint i, num;

	if (!size)	return;

	for (i = 0, num = 5; i < size; i++)
	{
		data[i] = (byte) ((int) key[num] + i ^ (int) data[i]);

		if (++num > 250)
			num = 0;
	}
}

uint my_NDS_CRC16(void* PTR, uint size)
{
	uint result, i;
	byte* buffer;

	uint my_array[8] = {
		0x1234D0C1,
		0x5678C181,
		0xABCDE301,
		0xFDEAC601,

		0x6890AC01,
		0xAABBD801,
		0xC098F001,
		0x4A50A001
	};

	result = 0xFFFFFFFF;
	buffer = (byte*) PTR;

	if (!size)
		return result;

	for (i = 0; i < size; i++)
	{
		result ^= (uint) buffer[i];

		for (byte k = 0; k < 8; k++)
		{
			byte num5 = (byte) (result & 1);
			result >>= 1;

			if (num5)
				result ^= my_array[k] << (7 - k);
		}
	}

	return result;
}

int return_help(int exitcode)
{
	puts("==== sdbt (SaveDongle bin tool) Example Usage:\n"
		"\tsdbt extract extracted_vXX.bin SaveDongle_vXX.bin\n"
		"\tsdbt build output.bin \"Version Title\" payload.bin eng_desc.txt chi_desc.txt\n"
		"\t\tThe version title can't be longer than 33 bytes!\n"
		"\t\tThe payload bin can't be bigger than XXXXX bytes!\n"
		"\t\teng_desc.txt can't be bigger than 255 bytes and must be GB2312-encoded!\n"
		"\t\t\teng_desc.txt can be ASCII-encoded as GB2312 is an extends ASCII!\n"
		"\t\tchi_desc.txt can't be bigger than 255 bytes and must be GB2312-encoded!\n"
		"\tsdbt make_debug_bin debug.bin\n"
		"\t\tThis makes a bin file that activates debugging options in the firmware uploader program!\n"
		);
	return exitcode;
}

void delete_file(const char* path) {
#ifdef _WIN32
	DeleteFileA(path)
#else
	remove(path);
#endif
}

void my_assert(int condition, const char* message) {
	if (condition != 1) {
		if (message) puts(message);
		exit(1);
	}
}

int main(int argc, char* argv[]) {
	FILE *outputFP, *payloadFP, *binFP, *engdescFP, *chidescFP;
	uint size, payload_size;
	char *buf, *payloadPtr;
	char *argument1;
	HEX_HEADER hexheader, *hexheaderPtr;

	memset(&hexheader, 0, sizeof(hexheader));

	if (argc < 3)
		return return_help(1);

	argument1 = argv[1];

	if (!strcmp(argument1, "extract-hex")) {
		if (argc != 4) {
			printf("error incorrect argument amount\n");
			return 1;
		}

		binFP = fopen(argv[2], "rb");

		my_assert(!!binFP, "error can not open bin file");

		fseek(binFP, 0, SEEK_END);

		size = ftell(binFP);

		if (size < SMALLEST_BIN_FILE || size > LARGEST_BIN_FILE)
			my_assert(0, "error incorrect bin size");

		payload_size = size - sizeof(HEX_HEADER);

		fseek(binFP, 0, SEEK_SET);

		buf = malloc(size);

		my_assert(!!size, "error malloc failed");

		my_assert(
			fread(buf, 1, size, binFP) == size,
			"error fread failed");

		hexheaderPtr = (HEX_HEADER*) buf;
		payloadPtr = buf + sizeof(HEX_HEADER);

		my_assert(hexheaderPtr->g_number_of_versions == 1,
			"error incorrect number of versions");
		my_assert(0 == memcmp(hexheaderPtr->bin_format_version, constant_bin_format_version, sizeof(constant_bin_format_version)),
			"error bin format version is incorrect");
		my_assert(hexheaderPtr->hexinfo.is_enabled == 1,
			"error hex payload not enabled");
		// 256 = encryption_key
		my_assert(hexheaderPtr->hexinfo.payload_size == payload_size+256,
			"error header is incorrect");
		my_assert(hexheaderPtr->hexinfo.offset_of_payload_description == 0x3c,
			"error payload offset is incorrect");

		my_assert(my_NDS_CRC16(buf+4, size-4) == hexheaderPtr->checksum,
			"error incorrect checksum");

		SimpleEncryptDecrypt(payloadPtr, hexheaderPtr->encryption_key, payload_size);

		delete_file(argv[3]);

		outputFP = fopen(argv[3], "wb");

		my_assert(!!outputFP, "error can not open output file");

		my_assert(fwrite(payloadPtr, 1, payload_size, outputFP) == payload_size,
			"error failed to write payload out");

		(void) printf("success! payload written to \"%s\"\n", argv[3]);
		return 0;

	} else if (!strcmp(argument1, "build")) {
		if (argc != 7) {
			printf("error incorrect argument amount\n");
			return 1;
		}


	} else if (!strcmp(argument1, "make_debug_bin")) {
		if (argc != 3) {
			printf("error incorrect argument amount\n");
			return 1;
		}


	} else {
		return return_help(1);
	}
}

// $ArrayType$$$BY07K arrayTypeBy07K
// =
// uint/int var[8];

// $ArrayType$$$BY0BAA@E arrayTypeBy0BaAE
// =
// char var[0xbab] ?????????

