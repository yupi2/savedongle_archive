// Decompiled with JetBrains decompiler
// Type: HIDBootLoader.Form1
// Assembly: HIDBootLoader, Version=1.0.4350.28629, Culture=neutral, PublicKeyToken=null
// MVID: C2ABEB73-C84E-41BA-807E-B4913B3F1A22
// Assembly location: C:\Temp\SaveDongle Firmware Uploader.exe

using <CppImplementationDetails>;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace HIDBootLoader
{
	public class Form1 : Form
	{
		private Thread ReadThread;
		private Thread ProgramThread;
		private Thread EraseThread;
		private Thread QueryThread;
		private Thread VerifyThread;
		private Thread UnlockConfigThread;
		private Thread ResetThread;
		private byte QueryThreadResults;
		private byte ProgramThreadResults;
		private byte EraseThreadResults;
		private byte VerifyThreadResults;
		private byte ReadThreadResults;
		private byte UnlockConfigThreadResults;
		private byte ResetThreadResults;
		private bool btn_Verify_restore;
		private bool btn_ResetDevice_restore;
		private bool btn_DumpMemory_restore;
		private bool btn_Query_restore;
		private bool btn_ProgramVerify_restore;
		private bool btn_OpenHexFile_restore;
		private bool btn_ExportHex_restore;
		private bool btn_EraseDevice_restore;
		private bool btn_ReadDevice_restore;
		private bool ckbox_ConfigWordProgramming_restore;
		private static unsafe _MEMORY_REGION* memoryRegions;
		private byte progressStatus;
		private byte bootloaderState;
		private byte bytesPerInstructionWord;
		private byte bytesPerAddressInHex;
		private bool unlockStatus;
		private bool enablePrint;
		private byte bytesPerAddress;
		private byte bytesPerPacket;
		private byte memoryRegionsDetected;
		private bool inTimer;
		private bool deviceAttached;
		private unsafe byte* pData;
		private unsafe byte* pData0;
		private unsafe byte* pData1;
		private unsafe byte* pData2;
		private unsafe byte* pData3;
		private unsafe byte* pData4;
		private unsafe byte* pData5;
		private bool gbol_SuccessProgram;
		private Button btn_Verify;
		private Button btn_ResetDevice;
		private Button btn_DumpMemory;
		private Button btn_Query;
		private Button btn_ProgramVerify;
		private Button btn_OpenHexFile;
		private Button btn_ExportHex;
		private Button btn_EraseDevice;
		private Button btn_ReadDevice;
		private SaveFileDialog dialog_ExportHex;
		private ListBox listBox1;
		private ProgressBar progressBar_Status;
		private IContainer components;
		private Button btn_ClearListbox;
		private CheckBox ckbox_ConfigWordProgramming;
		private PictureBox pictureBox1;
		private ComboBox comboBox_Language;
		private Label label1;
		private TextBox textBox1;
		private Button button_mHex;
		private Label label3;
		private ComboBox comboBox_Firmware;
		private System.Windows.Forms.Timer tmr_ThreadStatus;

		public unsafe Form1()
		{
			try
			{
				this.InitializeComponent();
				Form1 form1_1 = this;
				int num1 = form1_1.btn_Verify.Enabled ? 1 : 0;
				form1_1.btn_Verify_restore = num1 != 0;
				Form1 form1_2 = this;
				int num2 = form1_2.btn_ResetDevice.Enabled ? 1 : 0;
				form1_2.btn_ResetDevice_restore = num2 != 0;
				Form1 form1_3 = this;
				int num3 = form1_3.btn_ProgramVerify.Enabled ? 1 : 0;
				form1_3.btn_ProgramVerify_restore = num3 != 0;
				Form1 form1_4 = this;
				int num4 = form1_4.btn_OpenHexFile.Enabled ? 1 : 0;
				form1_4.btn_OpenHexFile_restore = num4 != 0;
				Form1 form1_5 = this;
				int num5 = form1_5.btn_ExportHex.Enabled ? 1 : 0;
				form1_5.btn_ExportHex_restore = num5 != 0;
				Form1 form1_6 = this;
				int num6 = form1_6.btn_EraseDevice.Enabled ? 1 : 0;
				form1_6.btn_EraseDevice_restore = num6 != 0;
				Form1 form1_7 = this;
				int num7 = form1_7.btn_ReadDevice.Enabled ? 1 : 0;
				form1_7.btn_ReadDevice_restore = num7 != 0;
				Form1 form1_8 = this;
				int num8 = form1_8.ckbox_ConfigWordProgramming.Enabled ? 1 : 0;
				form1_8.ckbox_ConfigWordProgramming_restore = num8 != 0;
				this.ReInitializeComponent();
				Form1.memoryRegions = (_MEMORY_REGION*) @new(54U);
				this.memoryRegionsDetected = 0;
				byte region = 0;
				do
				{
					this.setMemoryRegion(region, NULL);
					++region;
				}
				while (region < 6U);
				this.unlockStatus = false;
				this.enablePrint = false;
				this.inTimer = false;
				this.deviceAttached = false;
				this.progressStatus = 0;
				this.bytesPerAddress = 0;
				this.bootloaderState = byte.MaxValue;
				this.ProgramThreadResults = byte.MaxValue;
				_DEV_BROADCAST_DEVICEINTERFACE_W deviceinterfaceW;
				^(int&) ((IntPtr) &deviceinterfaceW + 4) = 5;
				^(int&) @deviceinterfaceW = 32;
				^(int&) ((IntPtr) &deviceinterfaceW + 8) = 0;
				__memcpy((_DEV_BROADCAST_DEVICEINTERFACE_W&) ((IntPtr) &deviceinterfaceW + 12), @HIDBootLoader.InterfaceClassGuid, 16);
				RegisterDeviceNotificationUM(this.Handle, &deviceinterfaceW, 0U);
				HIDBootLoader.Status = this.TryToFindHIDDeviceFromVIDPID() ? 1 : 0;
				HIDBootLoader.MyDeviceAttachedStatus = 0;
				this.DeviceRemoved();
				this.ListBoxUpdate(1);
				this.tmr_ThreadStatus.Enabled = true;
				this.tmr_ThreadStatus.Start();
			}
			__fault
			{
				base.Dispose(true);
			}
		}

		private unsafe void ~Form1()
		{
			IContainer components = this.components;
			if (components != null)
				components.Dispose();
			byte region = 0;
			do
			{
				byte* memoryRegion = this.getMemoryRegion(region);
				this.pData = memoryRegion;
				if ((IntPtr) memoryRegion != IntPtr.Zero)
				{
					free(memoryRegion);
					this.setMemoryRegion(region, NULL);
				}
				++region;
			}
			while (region < 6U);
		}

		protected unsafe void CreateTempFolder()
		{
			if (Directory.Exists("c:\\Temp"))
				return;
			_mkdir("c:\\Temp");
		}

		protected unsafe uint NDS_CRC16(FILE* fp, uint size)
		{
			uint arrayTypeBy07K[8] = {
				0x1234D0C1,
				0x5678C181,
				0xABCDE301,
				0xFDEAC601,

				0x6890AC01,
				0xAABBD801,
				0xC098F001,
				0x4A50A001
			};

			uint result = 0xFFFFFFFF;
			fseek(fp, 4, SEEK_SET);

			if (size == 0) return result;

			for (uint i = size; i > 0; i--)
			{
				byte num2;
				fread(&num2, 1, 1, fp);

				result ^= num2;

				for (byte num4 = 0; num4 < 8; num4++)
				{
					byte num5 = (byte) result & 1;
					result >>= 1;

					if (num5)
						result ^= (my_array[num4]) << (7 - num4);
				}
			}

			return maxValue;
		}

		protected unsafe void SimpleEncryptDecrypt(byte* data, byte* key, uint size)
		{
			if (!size) return;

			for (uint i = 0, num = 5; i < size; i++)
			{
				data[i] = (byte) ((int) key[num] + 1 ^ (int) data[i]);

				if (++num > 250)
					num = 0;
			}
		}

		protected unsafe void ExtractHexFile(FILE* fp, uint offset, uint size)
		{
			fseek(fp, offset + 256, SEEK_SET);

			byte* data = (byte*)malloc(size - 256);
			fread(data, 1, size - 256, fp);

			fseek(fp, &hexinfo + 512, SEEK_SET);

			// $ArrayType$$$BY0BAA@E arrayTypeBy0BaAE;
			byte simple_ed_key[256]; // Unsure about size;
			fread(simple_ed_key, 1, 256, fp);
			SimpleEncryptDecrypt(data, simple_ed_key, size - 256);

			FILE* tmpFile = fopen("C:\\Temp\\tmp.tmp", "wb");
			fwrite(data, size-256, tmpFile);
			fclose(tmpFile);

			free(data);
		}

		protected unsafe void UpdateFirmwareDescriptor()
		{
			int num1 = ^(int&) (this.comboBox_Firmware.SelectedIndex * 4 + (IntPtr) &HIDBootLoader.g_index);
			HIDBootLoader.g_id = num1;
			switch (this.comboBox_Language.SelectedIndex)
			{
				case 0:
					this.textBox1.Text = HIDBootLoader.g_number_of_versions <= 0 ? "Firmware Description:" : "Firmware Description:" + Environment.NewLine + new string((sbyte*) (num1 * 512 + (IntPtr) &HIDBootLoader.hex_description));
					break;
				case 1:
					this.textBox1.Text = HIDBootLoader.g_number_of_versions <= 0 ? "固件版本说明:" : "固件版本说明:" + Environment.NewLine + new string((sbyte*) (num1 * 512 + (IntPtr) &HIDBootLoader.hex_description));
					break;
			}
			if (HIDBootLoader.g_number_of_versions <= 0)
				return;

			FILE* fp = fopen(HIDBootLoader.g_pszSourcePath, "rb");
			int num2 = num1 * 44;
			// extract(fp, &HEX_HEADER.encryption_key, HEX_HEADER.HEX_INFO.payload_size);
			this.ExtractHexFile(fp, (uint) (^(int&) (num2 + (IntPtr) &HIDBootLoader.hexinfo) + 512), (uint) ^(int&) (num2 + ((IntPtr) &HIDBootLoader.hexinfo + 4)));
			fclose(fp);
		}

		protected unsafe void UpdateFirmwareListBox()
		{
			if (HIDBootLoader.g_number_of_versions == 0)
				return;
			int num1 = 0;
			if (0 < HIDBootLoader.g_number_of_versions)
			{
				g_index$$BY0A@H* gIndexBy0AHPtr = &HIDBootLoader.g_index;
				int num2 = (int) ((IntPtr) &HIDBootLoader.hexinfo + 10);
				int num3 = (int) ((IntPtr) &HIDBootLoader.hexinfo + 8);
				do
				{
					if (1 == *(byte*) num3)
					{
						this.comboBox_Firmware.Items.AddRange(new object[1]
						{
							(object) new string((sbyte*) num2)
						});
						*(int*) gIndexBy0AHPtr = num1;
						gIndexBy0AHPtr += 4;
					}
					++num1;
					num3 += 44;
					num2 += 44;
				}
				while (num1 < HIDBootLoader.g_number_of_versions);
			}
			this.comboBox_Firmware.SelectedIndex = 0;
			this.UpdateFirmwareDescriptor();
		}

		protected void ClearAll()
		{
			HIDBootLoader.g_number_of_versions = 0;
			this.comboBox_Firmware.Items.Clear();
			this.comboBox_Firmware.Text = "";
			switch (this.comboBox_Language.SelectedIndex)
			{
				case 0:
					this.textBox1.Text = "Firmware Description:";
					break;
				case 1:
					this.textBox1.Text = "固件版本说明:";
					break;
			}
			HIDBootLoader.g_first_time = 0;
		}

		protected unsafe void Load_mHexFile(sbyte* filename)
		{
			this.CreateTempFolder();
			FILE* fp = fopen(filename, "rb");
			fseek(fp, 0, 2);
			uint num1 = ftell(fp);
			int num2 = this.NDS_CRC16(fp, num1 - 4U);
			fseek(fp, 0, 0);
			uint num3;
			int num4 = fread(&num3, 4U, 1U, fp);
			int num5 = num3;
			if (num2 != num5)
			{
				fclose(fp);
				switch (this.comboBox_Language.SelectedIndex)
				{
					case 0:
						this.enablePrint = true;
						this.listBox1.Items.Add((object) ("Read <" + new string(filename) + "> file error ..."));
						this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
						this.enablePrint = true;
						this.listBox1.Items.Add((object) "Please download BIN file from official web site.");
						this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
						this.enablePrint = false;
						break;
					case 1:
						this.enablePrint = true;
						this.listBox1.Items.Add((object) ("读取 <" + new string(filename) + "> 文件错误 。。。"));
						this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
						this.enablePrint = true;
						this.listBox1.Items.Add((object) "请到官网重新下载 BIN 文件。");
						this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
						this.enablePrint = false;
						break;
				}
			}
			else
			{
				fseek(fp, 4, 0);
				int num6 = fread(&HIDBootLoader.g_number_of_versions, 4U, 1U, fp);
				fseek(fp, 16, 0);
				int num7 = fread(&HIDBootLoader.hexinfo, 44U, (uint) HIDBootLoader.g_number_of_versions, fp);
				int num8 = 0;
				if (0 < HIDBootLoader.g_number_of_versions)
				{
					sbyte* numPtr = (sbyte*) &HIDBootLoader.hex_description;
					HEX_INFO* hexInfoPtr = (HEX_INFO*) &HIDBootLoader.hexinfo;
					do
					{
						fseek(fp, *(int*) hexInfoPtr, 0);
						int num9 = fread(numPtr, 1U, 512U, fp);
						++num8;
						hexInfoPtr += 44;
						numPtr += 512;
					}
					while (num8 < HIDBootLoader.g_number_of_versions);
				}
				fclose(fp);
				sbyte* numPtr1 = filename;
				sbyte* numPtr2 = (sbyte*) &HIDBootLoader.g_pszSourcePath;
				sbyte num10;
				do
				{
					num10 = *numPtr1;
					*numPtr2 = num10;
					++numPtr1;
					++numPtr2;
				}
				while (num10 != 0);
				this.UpdateFirmwareListBox();
			}
		}

		protected void SelectProduct()
		{
		}

		protected void InitializeLanguage()
		{
			this.gbol_SuccessProgram = false;
			switch (this.comboBox_Language.SelectedIndex)
			{
				case 0:
					this.btn_ProgramVerify.Text = "Program";
					this.btn_OpenHexFile.Text = "Open BIN File";
					this.button_mHex.Text = "Open BIN File";
					this.label1.Text = "Language";
					this.listBox1.Items.Clear();
					this.label3.Text = "Select Firmware";
					this.UpdateFirmwareDescriptor();
					this.ListBoxUpdate(1);
					break;
				case 1:
					this.btn_ProgramVerify.Text = "编程";
					this.btn_OpenHexFile.Text = "选择 BIN 文件";
					this.button_mHex.Text = "选择 BIN 文件";
					this.label1.Text = "语言：";
					this.label3.Text = "选择固件版本";
					this.UpdateFirmwareDescriptor();
					this.listBox1.Items.Clear();
					this.ListBoxUpdate(1);
					break;
			}
		}

		protected unsafe void ListBoxUpdate(int type)
		{
			switch (type)
			{
				case 1:
					this.gbol_SuccessProgram = false;
					this.comboBox_Language.Enabled = true;
					switch (this.comboBox_Language.SelectedIndex)
					{
						case 0:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "Device not detected!");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "Please press the <Upgrade Button> at the save donggle for few seconds");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "and then release it to enter program mode!");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							return;
						case 1:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "检测不到存档电子狗！");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "按着存档电子狗上的 <Upgrade> 键几秒。。。");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "让后放开以便进入编程模式");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							return;
						default:
							return;
					}
				case 2:
					this.gbol_SuccessProgram = false;
					this.comboBox_Language.Enabled = false;
					switch (this.comboBox_Language.SelectedIndex)
					{
						case 0:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "Device attached.");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "Save dongle found!");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "Select the correspond BIN file.");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							return;
						case 1:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "设备连接成功。。。");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "发现存档电子狗！");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "请选择 BIN 文件。");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							return;
						default:
							return;
					}
				case 3:
					this.comboBox_Language.Enabled = true;
					this.ClearAll();
					switch (this.comboBox_Language.SelectedIndex)
					{
						case 0:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) ("Program <" + new string((sbyte*) (HIDBootLoader.g_id * 44 + ((IntPtr) &HIDBootLoader.hexinfo + 10))) + ">  success!"));
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "To re-program again,");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "please press the <Upgrade Button> at the donggle for few seconds");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "and then release it to enter program mode again!");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							return;
						case 1:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) ("固件 <" + new string((sbyte*) (HIDBootLoader.g_id * 44 + ((IntPtr) &HIDBootLoader.hexinfo + 10))) + "> 升级成功！"));
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "如需重新刷入固件。。。");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "按着存档电子狗上的 <Upgrade> 键几秒。。。");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "让后放开以便再进入编程模式。");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							return;
						default:
							return;
					}
				case 4:
					this.gbol_SuccessProgram = false;
					switch (this.comboBox_Language.SelectedIndex)
					{
						case 0:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) ("Loading <" + new string((sbyte*) (^(int&) (this.comboBox_Firmware.SelectedIndex * 4 + (IntPtr) &HIDBootLoader.g_index) * 44 + ((IntPtr) &HIDBootLoader.hexinfo + 10))) + "> success."));
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "Ready to program the device.");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							return;
						case 1:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) ("已成功导入 <" + new string((sbyte*) (^(int&) (this.comboBox_Firmware.SelectedIndex * 4 + (IntPtr) &HIDBootLoader.g_index) * 44 + ((IntPtr) &HIDBootLoader.hexinfo + 10))) + "> 固件。"));
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "可以按〈编程〉键进行固件更新。");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							return;
						default:
							return;
					}
				case 5:
					this.gbol_SuccessProgram = true;
					switch (this.comboBox_Language.SelectedIndex)
					{
						case 0:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "Programming Complete");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							return;
						case 1:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "编程完毕！");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							return;
						default:
							return;
					}
				case 6:
					this.gbol_SuccessProgram = false;
					switch (this.comboBox_Language.SelectedIndex)
					{
						case 0:
							if (!this.enablePrint)
								return;
							this.listBox1.Items.Add((object) "Programming Started");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							return;
						case 1:
							if (!this.enablePrint)
								return;
							this.listBox1.Items.Add((object) "开始刷入新固件。。。");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							return;
						default:
							return;
					}
				case 7:
					this.gbol_SuccessProgram = false;
					switch (this.comboBox_Language.SelectedIndex)
					{
						case 0:
							if (!this.enablePrint)
								return;
							this.listBox1.Items.Add((object) "Erase Complete");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							return;
						case 1:
							if (!this.enablePrint)
								return;
							this.listBox1.Items.Add((object) "成功删除固件。");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							return;
						default:
							return;
					}
				case 8:
					this.gbol_SuccessProgram = false;
					switch (this.comboBox_Language.SelectedIndex)
					{
						case 0:
							if (!this.enablePrint)
								return;
							this.listBox1.Items.Add((object) "Erase Started (no status update until complete, may take several seconds)");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							return;
						case 1:
							if (!this.enablePrint)
								return;
							this.listBox1.Items.Add((object) "开始删除固件内容。。。");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							return;
						default:
							return;
					}
			}
		}

		protected unsafe void GetIconTitle(sbyte* title)
		{
			sbyte arrayTypeBy0DeE[52] = {
				122, 22, -1, -25, 78, 9, 47, 24, 113, 110, 104, -71, 27, -55,
				73, -118, -93, 58, -60, -69, -85, 11, 19, -95, -23, -65, -29,
				-85, -91, 77, 45, -98, -20, -120, 27, 112, -56, 38, 0, -111, 58,
				-13, 45, -28, 122, 110, -93, -71, 32, -14, -75, -97
			};
			sbyte arrayTypeBy0MaE[192] = {
				-119, 83, -47, 74, 16, 41, -24, -116, 28, -20, -74, -22, 70, -57,
				23, -117, 37, 21, 49, -88, -94, 107, 67, -79, -99, -30, -37, 11,
				-121, -101, -80, 17, 4, 14, 113, -46, 41, 119, -119, -126, 10,
				102, 65, sbyte.MaxValue, 29, 11, 72, -1, 114, -69, 36, -3, -62,
				72, -95, -101, -2, 123, sbyte.MaxValue, -50, -120, -37, -122, -39,
				-123, 59, 28, -80, -36, -88, 51, 7, -65, 81, 46, -29, 14, -102, 0,
				-105, 30, 6, -64, -105, 67, -99, -40, -74, 69, -60, -122, 103, 95,
				0, -8, -120, -102, -92, 82, -98, -57, -86, -118, -125, 117, -20,
				-59, 24, -82, -50, -61, 47, 26, 43, -7, 24, -1, -82, 26, -11, 83,
				11, -75, 51, 81, -89, -3, -24, -88, -31, -94, 100, -74, 34, 23, 67,
				sbyte.MinValue, -52, 10, -40, -82, 59, -70, 64, -41, -39, -110, 74,
				-119, -33, 4, 16, -18, -101, 24, 43, 106, 119, 105, -118, 104, -12,
				-7, -71, -94, 33, 21, 110, -26, 30, 59, 3, 98, 48, -101, 96, 65,
				126, 37, -101, -98, -113, -59, 82, 16, 8, -8, -62, 105, -95, 33, 17
			};
			int index = 0;
			sbyte* numPtr1 = title + 3;
			sbyte* numPtr2 = title + 1;
			sbyte* numPtr3 = title + 2;
			do
			{
				*(sbyte*) (index + (IntPtr) title) = (sbyte) ((int) ^(byte&) (index + ((IntPtr) &arrayTypeBy0MaE + 36)) ^ (int) ^(byte&) (index + (IntPtr) &arrayTypeBy0DeE));
				numPtr2[index] = (sbyte) ((int) ^(byte&) (index + ((IntPtr) &arrayTypeBy0MaE + 37)) ^ (int) ^(byte&) (index + ((IntPtr) &arrayTypeBy0DeE + 1)));
				numPtr3[index] = (sbyte) ((int) ^(byte&) (index + ((IntPtr) &arrayTypeBy0MaE + 38)) ^ (int) ^(byte&) (index + ((IntPtr) &arrayTypeBy0DeE + 2)));
				numPtr1[index] = (sbyte) ((int) ^(byte&) (index + ((IntPtr) &arrayTypeBy0MaE + 39)) ^ (int) ^(byte&) (index + ((IntPtr) &arrayTypeBy0DeE + 3)));
				index += 4;
			}
			while (index < 52);
			title[52] = 0;
		}

		protected unsafe void ReInitializeComponent()
		{
			$ArrayType$$$BY0EA@D arrayTypeBy0EaD;
			this.GetIconTitle((sbyte*) &arrayTypeBy0EaD);
			this.Text = new string((sbyte*) &arrayTypeBy0EaD);
			switch (GetSystemDefaultUILanguage())
			{
				case 2052:
				case 1028:
					this.comboBox_Language.SelectedIndex = 1;
					break;
			}
			this.InitializeLanguage();
		}

		protected void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
			this.listBox1 = new ListBox();
			this.btn_ProgramVerify = new Button();
			this.btn_OpenHexFile = new Button();
			this.btn_ReadDevice = new Button();
			this.btn_ExportHex = new Button();
			this.btn_EraseDevice = new Button();
			this.progressBar_Status = new ProgressBar();
			Form1 form1_1 = this;
			System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer(form1_1.components);
			form1_1.tmr_ThreadStatus = timer;
			this.btn_Verify = new Button();
			this.dialog_ExportHex = new SaveFileDialog();
			this.btn_ResetDevice = new Button();
			this.btn_DumpMemory = new Button();
			this.btn_Query = new Button();
			this.btn_ClearListbox = new Button();
			this.ckbox_ConfigWordProgramming = new CheckBox();
			this.pictureBox1 = new PictureBox();
			this.comboBox_Language = new ComboBox();
			this.label1 = new Label();
			this.textBox1 = new TextBox();
			this.button_mHex = new Button();
			this.label3 = new Label();
			this.comboBox_Firmware = new ComboBox();
			((ISupportInitialize) this.pictureBox1).BeginInit();
			this.SuspendLayout();
			this.listBox1.Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 14;
			this.listBox1.Location = new Point(3, 265);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new Size(556, 172);
			this.listBox1.TabIndex = 10;
			this.btn_ProgramVerify.Enabled = false;
			this.btn_ProgramVerify.Location = new Point(326, 56);
			this.btn_ProgramVerify.Name = "btn_ProgramVerify";
			this.btn_ProgramVerify.Size = new Size(132, 37);
			this.btn_ProgramVerify.TabIndex = 22;
			this.btn_ProgramVerify.Text = "Program";
			this.btn_ProgramVerify.UseVisualStyleBackColor = true;
			this.btn_ProgramVerify.Click += new EventHandler(this.btn_ProgramVerify_Click);
			this.btn_OpenHexFile.Enabled = false;
			this.btn_OpenHexFile.Location = new Point(456, 100);
			this.btn_OpenHexFile.Name = "btn_OpenHexFile";
			this.btn_OpenHexFile.Size = new Size(132, 38);
			this.btn_OpenHexFile.TabIndex = 24;
			this.btn_OpenHexFile.Text = "Open Hex File";
			this.btn_OpenHexFile.UseVisualStyleBackColor = true;
			this.btn_OpenHexFile.Visible = false;
			this.btn_OpenHexFile.Click += new EventHandler(this.btn_OpenHexFile_Click);
			this.btn_ReadDevice.Enabled = false;
			this.btn_ReadDevice.Location = new Point(330, 195);
			this.btn_ReadDevice.Name = "btn_ReadDevice";
			this.btn_ReadDevice.Size = new Size(108, 22);
			this.btn_ReadDevice.TabIndex = 25;
			this.btn_ReadDevice.Text = "Read Device";
			this.btn_ReadDevice.UseVisualStyleBackColor = true;
			this.btn_ReadDevice.Visible = false;
			this.btn_ReadDevice.Click += new EventHandler(this.btn_ReadDevice_Click);
			this.btn_ExportHex.Enabled = false;
			this.btn_ExportHex.Location = new Point(329, 195);
			this.btn_ExportHex.Name = "btn_ExportHex";
			this.btn_ExportHex.Size = new Size(108, 22);
			this.btn_ExportHex.TabIndex = 27;
			this.btn_ExportHex.Text = "Export Hex";
			this.btn_ExportHex.UseVisualStyleBackColor = true;
			this.btn_ExportHex.Visible = false;
			this.btn_ExportHex.Click += new EventHandler(this.btn_ExportHex_Click);
			this.btn_EraseDevice.Enabled = false;
			this.btn_EraseDevice.Location = new Point(330, 195);
			this.btn_EraseDevice.Name = "btn_EraseDevice";
			this.btn_EraseDevice.Size = new Size(108, 22);
			this.btn_EraseDevice.TabIndex = 28;
			this.btn_EraseDevice.Text = "Erase Device";
			this.btn_EraseDevice.UseVisualStyleBackColor = true;
			this.btn_EraseDevice.Visible = false;
			this.btn_EraseDevice.Click += new EventHandler(this.btn_EraseDevice_Click);
			this.progressBar_Status.Location = new Point(3, 238);
			this.progressBar_Status.Name = "progressBar_Status";
			this.progressBar_Status.Size = new Size(556, 21);
			this.progressBar_Status.TabIndex = 29;
			this.tmr_ThreadStatus.Interval = 1;
			this.tmr_ThreadStatus.Tick += new EventHandler(this.tmr_ThreadStatus_Tick);
			this.btn_Verify.Enabled = false;
			this.btn_Verify.Location = new Point(326, 195);
			this.btn_Verify.Name = "btn_Verify";
			this.btn_Verify.Size = new Size(107, 22);
			this.btn_Verify.TabIndex = 32;
			this.btn_Verify.Text = "Verify";
			this.btn_Verify.UseVisualStyleBackColor = true;
			this.btn_Verify.Visible = false;
			this.btn_Verify.Click += new EventHandler(this.btn_Verify_Click);
			this.dialog_ExportHex.DefaultExt = "hex";
			this.dialog_ExportHex.Filter = "Hex Files|*.hex|All files|*.*";
			this.dialog_ExportHex.ShowHelp = true;
			this.btn_ResetDevice.Enabled = false;
			this.btn_ResetDevice.Location = new Point(327, 195);
			this.btn_ResetDevice.Name = "btn_ResetDevice";
			this.btn_ResetDevice.Size = new Size(109, 22);
			this.btn_ResetDevice.TabIndex = 33;
			this.btn_ResetDevice.Text = "Reset Device";
			this.btn_ResetDevice.UseVisualStyleBackColor = true;
			this.btn_ResetDevice.Visible = false;
			this.btn_ResetDevice.Click += new EventHandler(this.btn_ResetDevice_Click);
			this.btn_DumpMemory.Enabled = false;
			this.btn_DumpMemory.Location = new Point(326, 195);
			this.btn_DumpMemory.Name = "btn_DumpMemory";
			this.btn_DumpMemory.Size = new Size(107, 22);
			this.btn_DumpMemory.TabIndex = 34;
			this.btn_DumpMemory.Text = "Dump Memory";
			this.btn_DumpMemory.UseVisualStyleBackColor = true;
			this.btn_DumpMemory.Visible = false;
			this.btn_DumpMemory.Click += new EventHandler(this.button1_Click);
			this.btn_Query.Enabled = false;
			this.btn_Query.Location = new Point(330, 195);
			this.btn_Query.Name = "btn_Query";
			this.btn_Query.Size = new Size(107, 22);
			this.btn_Query.TabIndex = 35;
			this.btn_Query.Text = "Query";
			this.btn_Query.UseVisualStyleBackColor = true;
			this.btn_Query.Visible = false;
			this.btn_Query.Click += new EventHandler(this.btn_Query_Click);
			this.btn_ClearListbox.Enabled = false;
			this.btn_ClearListbox.Location = new Point(329, 195);
			this.btn_ClearListbox.Name = "btn_ClearListbox";
			this.btn_ClearListbox.Size = new Size(107, 22);
			this.btn_ClearListbox.TabIndex = 36;
			this.btn_ClearListbox.Text = "Clear Listbox";
			this.btn_ClearListbox.UseVisualStyleBackColor = true;
			this.btn_ClearListbox.Visible = false;
			this.btn_ClearListbox.Click += new EventHandler(this.btn_ClearListbox_Click);
			this.ckbox_ConfigWordProgramming.AutoSize = true;
			this.ckbox_ConfigWordProgramming.Enabled = false;
			this.ckbox_ConfigWordProgramming.Location = new Point(329, 173);
			this.ckbox_ConfigWordProgramming.Name = "ckbox_ConfigWordProgramming";
			this.ckbox_ConfigWordProgramming.Size = new Size(102, 16);
			this.ckbox_ConfigWordProgramming.TabIndex = 26;
			this.ckbox_ConfigWordProgramming.Text = "configuration";
			this.ckbox_ConfigWordProgramming.UseVisualStyleBackColor = true;
			this.ckbox_ConfigWordProgramming.Visible = false;
			this.ckbox_ConfigWordProgramming.CheckedChanged += new EventHandler(this.ckbox_ConfigWordProgramming_CheckedChanged);
			this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new Point(3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(318, 215);
			this.pictureBox1.TabIndex = 37;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
			this.comboBox_Language.AccessibleName = "";
			this.comboBox_Language.FormattingEnabled = true;
			this.comboBox_Language.Items.AddRange(new object[2]
			{
				(object) "English",
				(object) "简体中文"
			});
			this.comboBox_Language.Location = new Point(478, 27);
			this.comboBox_Language.Name = "comboBox_Language";
			this.comboBox_Language.Size = new Size(83, 20);
			this.comboBox_Language.TabIndex = 38;
			this.comboBox_Language.Tag = (object) "";
			this.comboBox_Language.Text = "English";
			this.comboBox_Language.SelectedIndexChanged += new EventHandler(this.comboBox_Language_SelectedIndexChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new Point(476, 12);
			this.label1.Name = "label1";
			this.label1.Size = new Size(53, 12);
			this.label1.TabIndex = 39;
			this.label1.Text = "Language";
			this.textBox1.AcceptsReturn = true;
			this.textBox1.Location = new Point(327, 144);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = ScrollBars.Both;
			this.textBox1.Size = new Size(256, 73);
			this.textBox1.TabIndex = 43;
			this.textBox1.Text = "Firmware description ...";
			this.button_mHex.Enabled = false;
			this.button_mHex.Location = new Point(326, 12);
			this.button_mHex.Name = "button_mHex";
			this.button_mHex.Size = new Size(132, 38);
			this.button_mHex.TabIndex = 44;
			this.button_mHex.Text = "Open BIN File";
			this.button_mHex.UseVisualStyleBackColor = true;
			this.button_mHex.Click += new EventHandler(this.button_mHex_Click);
			this.label3.AutoSize = true;
			this.label3.Location = new Point(328, 103);
			this.label3.Name = "label3";
			this.label3.Size = new Size(95, 12);
			this.label3.TabIndex = 46;
			this.label3.Text = "Select Firmware";
			this.comboBox_Firmware.AccessibleName = "";
			this.comboBox_Firmware.FormattingEnabled = true;
			this.comboBox_Firmware.Location = new Point(326, 118);
			this.comboBox_Firmware.Name = "comboBox_Firmware";
			this.comboBox_Firmware.Size = new Size(256, 20);
			this.comboBox_Firmware.TabIndex = 45;
			this.comboBox_Firmware.Tag = (object) "";
			this.comboBox_Firmware.SelectedIndexChanged += new EventHandler(this.comboBox_Firmware_SelectedIndexChanged);
			this.AutoScaleDimensions = new SizeF(6f, 12f);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(594, 447);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox_Firmware);
			this.Controls.Add(this.button_mHex);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox_Language);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_ClearListbox);
			this.Controls.Add(this.btn_Query);
			this.Controls.Add(this.btn_DumpMemory);
			this.Controls.Add(this.btn_ResetDevice);
			this.Controls.Add(this.btn_Verify);
			this.Controls.Add(this.progressBar_Status);
			this.Controls.Add(this.btn_EraseDevice);
			this.Controls.Add(this.btn_ExportHex);
			this.Controls.Add(this.ckbox_ConfigWordProgramming);
			this.Controls.Add(this.btn_ReadDevice);
			this.Controls.Add(this.btn_OpenHexFile);
			this.Controls.Add(this.btn_ProgramVerify);
			this.Controls.Add(this.listBox1);
			this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "Form1";
			Form1 form1_2 = this;
			EventHandler eventHandler1 = new EventHandler(form1_2.Form1_Load);
			form1_2.Load += eventHandler1;
			Form1 form1_3 = this;
			EventHandler eventHandler2 = new EventHandler(form1_3.Form1_SizeChanged);
			form1_3.SizeChanged += eventHandler2;
			((ISupportInitialize) this.pictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private unsafe void QueryThreadStart()
		{
			_BOOTLOADER_COMMAND bootloaderCommand1;
			^(sbyte&) @bootloaderCommand1 = 0;
			__memset((_BOOTLOADER_COMMAND&) ((IntPtr) &bootloaderCommand1 + 1), 0, 65);
			_BOOTLOADER_COMMAND bootloaderCommand2;
			^(sbyte&) @bootloaderCommand2 = 0;
			__memset((_BOOTLOADER_COMMAND&) ((IntPtr) &bootloaderCommand2 + 1), 0, 65);
			uint num1 = 0;
			uint num2 = 0;
			this.memoryRegionsDetected = 0;
			void* fileW1 = CreateFileW((char*) ((IntPtr) HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt + 4), 1073741824U, 3U, NULL, 3U, 0U, NULL);
			HIDBootLoader.ErrorStatusWrite = Marshal.GetLastWin32Error();
			if (HIDBootLoader.ErrorStatusWrite != 0)
			{
				this.QueryThreadResults = 2;
				this.progressStatus = 100;
			}
			else
			{
				void* fileW2 = CreateFileW((char*) ((IntPtr) HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt + 4), 2147483648U, 3U, NULL, 3U, 0U, NULL);
				HIDBootLoader.ErrorStatusRead = (uint) Marshal.GetLastWin32Error();
				if (HIDBootLoader.ErrorStatusRead != 0)
				{
					this.QueryThreadResults = 3;
					CloseHandle(fileW1);
					this.progressStatus = 100;
				}
				else
				{
					this.progressStatus = 10;
					^(sbyte&) @bootloaderCommand1 = 0;
					^(sbyte&) ((IntPtr) &bootloaderCommand1 + 1) = 2;
					WriteFile(fileW1, &bootloaderCommand1, 65U, &num1, NULL);
					if (Marshal.GetLastWin32Error() == 0)
					{
						this.progressStatus = 50;
						ReadFile(fileW2, &bootloaderCommand2, 65U, &num2, NULL);
						if (Marshal.GetLastWin32Error() == 0)
						{
							this.progressStatus = 90;
							byte num3 = 0;
							do
							{
								int num4 = (int) num3 * 9;
								byte num5 = ^(byte&) (num4 + ((IntPtr) &bootloaderCommand2 + 4));
								if (num5 != 0xFF)
								{
									*(sbyte*) ((IntPtr) Form1.memoryRegions + num4) = num5;
									*(int*) (num4 + (IntPtr) Form1.memoryRegions + 1) = ^(int&) (num4 + ((IntPtr) &bootloaderCommand2 + 5));
									*(int*) (num4 + (IntPtr) Form1.memoryRegions + 5) = ^(int&) (num4 + ((IntPtr) &bootloaderCommand2 + 9));
									++this.memoryRegionsDetected;
									++num3;
								}
								else
									break;
							}
							while (num3 < 4U);
							switch (^(byte&) ((IntPtr) &bootloaderCommand2 + 3))
							{
								case 1:
									this.bytesPerAddress = 1;
									this.ckbox_ConfigWordProgramming_restore = true;
									break;
								case 2:
									this.bytesPerAddress = 2;
									this.ckbox_ConfigWordProgramming_restore = true;
									break;
								case 3:
									this.bytesPerAddress = 1;
									this.ckbox_ConfigWordProgramming_restore = false;
									break;
							}
							this.bytesPerPacket = ^(byte&) ((IntPtr) &bootloaderCommand2 + 2);
							this.QueryThreadResults = 1;
						}
						else
							this.QueryThreadResults = 3;
					}
					else
						this.QueryThreadResults = 2;
					CloseHandle(fileW1);
					CloseHandle(fileW2);
					this.progressStatus = 100;
				}
			}
		}

		private void btn_EraseDevice_Click(object sender, EventArgs e)
		{
			this.DisableButtons();
			this.bootloaderState = 2;
			this.EraseThreadResults = 0;
			Thread eraseThread = this.EraseThread;
			if (eraseThread != null && eraseThread.IsAlive)
				return;
			this.listBox1.Items.Clear();
			this.enablePrint = true;
			this.listBox1.Items.Add((object) "Erasing Device (no status update until complete, may take several seconds)");
			this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
			this.enablePrint = false;
			Thread thread = new Thread(new ThreadStart(this.EraseThreadStart));
			this.EraseThread = thread;
			thread.Start();
		}

		private unsafe void EraseThreadStart()
		{
			_BOOTLOADER_COMMAND bootloaderCommand = {0};
			uint num = 0;
			void* fileW = CreateFileW((char*) ((IntPtr) HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt + 4), 1073741824U, 3U, NULL, 3U, 0U, NULL);
			HIDBootLoader.ErrorStatusWrite = Marshal.GetLastWin32Error();
			if (HIDBootLoader.ErrorStatusWrite != 0)
			{
				this.EraseThreadResults = 2;
			}
			else
			{
				^(sbyte&) @bootloaderCommand = 0;
				^(sbyte&) ((IntPtr) &bootloaderCommand + 1) = 4;
				WriteFile(fileW, &bootloaderCommand, 65U, &num, NULL);
				this.EraseThreadResults = Marshal.GetLastWin32Error() != 0 ? 2 :1;
				CloseHandle(fileW);
			}
		}

		private void ckbox_ConfigWordProgramming_CheckedChanged(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			if (this.ckbox_ConfigWordProgramming.Checked)
			{
				this.btn_EraseDevice_restore = false;
				this.enablePrint = true;
				this.listBox1.Items.Add((object) "Disabling Erase button to prevent accidental erasing of the configuration words");
				this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
				this.enablePrint = true;
				this.listBox1.Items.Add((object) "     without reprogramming them");
				this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
				this.enablePrint = false;
			}
			Thread unlockConfigThread = this.UnlockConfigThread;
			if (unlockConfigThread != null && unlockConfigThread.IsAlive)
				return;
			this.btn_Verify_restore = false;
			this.btn_ProgramVerify_restore = false;
			this.btn_ExportHex_restore = false;
			this.btn_ReadDevice_restore = false;
			Form1 form1 = this;
			int num = form1.ckbox_ConfigWordProgramming.Checked ? 1 : 0;
			form1.unlockStatus = num != 0;
			this.bootloaderState = 5;
			this.UnlockConfigThreadResults = 0;
			Thread thread = new Thread(new ThreadStart(this.UnlockConfigThreadStart));
			this.UnlockConfigThread = thread;
			thread.Start();
		}

		private unsafe void UnlockConfigThreadStart()
		{
			_BOOTLOADER_COMMAND bootloaderCommand;
			^(sbyte&) @bootloaderCommand = 0;
			__memset((_BOOTLOADER_COMMAND&) ((IntPtr) &bootloaderCommand + 1), 0, 65);
			uint num = 0;
			void* fileW = CreateFileW((char*) ((IntPtr) HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt + 4), 1073741824U, 3U, NULL, 3U, 0U, NULL);
			HIDBootLoader.ErrorStatusWrite = Marshal.GetLastWin32Error();
			if (HIDBootLoader.ErrorStatusWrite != 0)
			{
				this.UnlockConfigThreadResults = 2;
			}
			else
			{
				^(sbyte&) @bootloaderCommand = 0;
				^(sbyte&) ((IntPtr) &bootloaderCommand + 1) = 3;
				^(sbyte&) ((IntPtr) &bootloaderCommand + 2) = this.unlockStatus ? 0 : 1;
				WriteFile(fileW, &bootloaderCommand, 65U, &num, NULL);
				this.UnlockConfigThreadResults = Marshal.GetLastWin32Error() != 0 ? 2 : 1;
				CloseHandle(fileW);
			}
		}

		private void btn_ReadDevice_Click(object sender, EventArgs e)
		{
			this.DisableButtons();
			Thread readThread = this.ReadThread;
			if (readThread != null && readThread.IsAlive)
				return;
			this.bootloaderState = 4;
			this.ReadThreadResults = 0;
			this.listBox1.Items.Clear();
			this.enablePrint = true;
			Thread thread = new Thread(new ThreadStart(this.ReadThreadStart));
			this.ReadThread = thread;
			thread.Start();
		}

		private unsafe void ReadThreadStart()
		{
			_BOOTLOADER_COMMAND bootloaderCommand1 = {0};
			_BOOTLOADER_COMMAND bootloaderCommand2 = {0};
			_BOOTLOADER_COMMAND bootloaderCommand3 = {0};
			uint num1 = GetTickCount();
			int num2 = 0;
			uint num3 = 0;
			uint num4 = 0;
			uint num5 = 0;
			uint num6 = 0;
			uint num7 = 0;
			uint num8 = 0;
			void* eventW1 = CreateEventW(NULL, 1, 1, L"WriteEvent");
			void* eventW2 = CreateEventW(NULL, 1, 1, L"WriteEvent2");
			void* eventW3 = CreateEventW(NULL, 1, 1, L"ReadEvent");
			_OVERLAPPED overlapped1 = {
				.Internal = 0,
				.InternalHigh = 0,
				.Offset = 0,
				.OffsetHigh = 0,
				.hEvent = eventW1;
			};
			_OVERLAPPED overlapped2 = {
				.Internal = 0,
				.InternalHigh = 0,
				.Offset = 0,
				.OffsetHigh = 0,
				.hEvent = eventW2;
			};
			_OVERLAPPED overlapped3 = {
				.Internal = 0,
				.InternalHigh = 0,
				.Offset = 0,
				.OffsetHigh = 0,
				.hEvent = eventW3;
			};
			SetEvent(eventW3);
			SetEvent(eventW2);
			SetEvent(eventW1);
			void* fileW1 = CreateFileW((char*) ((IntPtr) HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt + 4), 1073741824U, 3U, NULL, 3U, 1073741824U, NULL);
			if (Marshal.GetLastWin32Error() != 0)
			{
				this.enablePrint = true;
				this.ReadThreadResults = 3;
				this.progressStatus = 100;
			}
			else
			{
				void* fileW2 = CreateFileW((char*) ((IntPtr) HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt + 4), 2147483648U, 3U, NULL, 3U, 1073741824U, NULL);
				if (Marshal.GetLastWin32Error() != 0)
				{
					this.enablePrint = true;
					this.ReadThreadResults = (byte) 2;
					this.progressStatus = (byte) 100;
					CloseHandle(fileW1);
				}
				else
				{
					byte region = 0;
					if (0U < (uint) this.memoryRegionsDetected)
					{
						do
						{
							int num9 = (int) region * 9;
							uint num10 = (uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1);
							_MEMORY_REGION* memoryRegions = Form1.memoryRegions;
							byte* memoryRegion = this.getMemoryRegion(region);
							^(sbyte&) ((IntPtr) &bootloaderCommand1 + 1) = 7;
							^(int&) ((IntPtr) &bootloaderCommand1 + 2) = (int) num10;
							^(sbyte&) ((IntPtr) &bootloaderCommand1 + 6) = this.bytesPerPacket;
							^(sbyte&) @bootloaderCommand1 = 0;
							uint num11 = (uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 5);
							byte bytesPerAddress1 = this.bytesPerAddress;
							int num12 = (int) this.bytesPerPacket / (int) bytesPerAddress1;
							if (num10 + (uint) num12 > (uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + num11)
							{
								uint num13 = (uint) (num12 - *(int*) (num9 + (IntPtr) Form1.memoryRegions + 5));
								bytesPerAddress1 = this.bytesPerAddress;
								^(sbyte&) ((IntPtr) &bootloaderCommand1 + 6) = (sbyte) ((int) this.bytesPerPacket - ((int) num10 - *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + (int) num13) * (int) bytesPerAddress1);
							}
							if ((int) ^(byte&) ((IntPtr) &bootloaderCommand1 + 6) % (int) bytesPerAddress1 != 0)
							{
								byte bytesPerAddress2 = this.bytesPerAddress;
								do
								{
									^(sbyte&) ((IntPtr) &bootloaderCommand1 + 6) = (sbyte) ((int) ^(byte&) ((IntPtr) &bootloaderCommand1 + 6) + 1);
								}
								while ((int) ^(byte&) ((IntPtr) &bootloaderCommand1 + 6) % (int) bytesPerAddress2 != 0);
							}
							uint num14 = (uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 5);
							if (num10 < (uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + num14)
							{
								overlapped1.Internal = 0;
								overlapped1.InternalHigh = 0;
								overlapped1.Offset = 0;
								overlapped1.OffsetHigh = 0;
								overlapped1.hEvent = eventW1;
								if (WriteFile(fileW1, &bootloaderCommand1, 65U, &num3, &overlapped1) != 0)
								{
									num8 = 1U;
									num10 = (uint) this.bytesPerPacket / (uint) this.bytesPerAddress + num10;
									++num6;
								}
								else if (Marshal.GetLastWin32Error() == 997)
								{
									num8 = 1U;
									++num6;
									num10 = (uint) this.bytesPerPacket / (uint) this.bytesPerAddress + num10;
								}
								else
									goto label_16;
								overlapped3.Internal = 0;
								overlapped3.InternalHigh = 0;
								overlapped3.Offset = 0;
								overlapped3.OffsetHigh = 0;
								overlapped3.hEvent = eventW3;
								SetEvent(eventW3);
								^(sbyte&) @bootloaderCommand3 = 0;
								if (ReadFile(fileW2, &bootloaderCommand3, 65U, &num5, &overlapped3) == 0 && Marshal.GetLastWin32Error() != 997)
									goto label_49;
							}
label_16:
							do
							{
								do
								{
									do
									{
										if ((int) num8 == 0)
										{
											uint num13 = (uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 5);
											if (num10 >= (uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + num13)
												goto label_48;
										}
										uint num15 = (uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 5);
										this.progressStatus = (byte) (num10 * 100U / ((uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + num15));
										Sleep(0U);
										uint tickCount = GetTickCount();
										if (tickCount - num1 > 10000U)
										{
											if (num2 != 1)
											{
												num1 = tickCount;
												num2 = 1;
											}
											else
												goto label_50;
										}
										if (overlapped1.Internal != STATUS_PENDING && num8 < 10U)
										{
											num2 = 0;
											^(sbyte&) ((IntPtr) &bootloaderCommand1 + 1) = 7;
											^(int&) ((IntPtr) &bootloaderCommand1 + 2) = (int) num10;
											^(sbyte&) ((IntPtr) &bootloaderCommand1 + 6) = this.bytesPerPacket;
											^(sbyte&) @bootloaderCommand1 = 0;
											uint num13 = (uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 5);
											byte bytesPerAddress2 = this.bytesPerAddress;
											int num16 = (int) this.bytesPerPacket / (int) bytesPerAddress2;
											if (num10 + (uint) num16 > (uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + num13)
											{
												uint num17 = (uint) (num16 - *(int*) (num9 + (IntPtr) Form1.memoryRegions + 5));
												bytesPerAddress2 = this.bytesPerAddress;
												^(sbyte&) ((IntPtr) &bootloaderCommand1 + 6) = (sbyte) ((int) this.bytesPerPacket - ((int) num17 - *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + (int) num10) * (int) bytesPerAddress2);
											}
											if ((int) ^(byte&) ((IntPtr) &bootloaderCommand1 + 6) % (int) bytesPerAddress2 != 0)
											{
												byte bytesPerAddress3 = this.bytesPerAddress;
												do
												{
													^(sbyte&) ((IntPtr) &bootloaderCommand1 + 6) = (sbyte) ((int) ^(byte&) ((IntPtr) &bootloaderCommand1 + 6) + 1);
												}
												while ((int) ^(byte&) ((IntPtr) &bootloaderCommand1 + 6) % (int) bytesPerAddress3 != 0);
											}
											overlapped1.Internal = 0;
											overlapped1.InternalHigh = 0;
											overlapped1.Offset = 0;
											overlapped1.OffsetHigh = 0;
											overlapped1.hEvent = eventW1;
											uint num18 = (uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 5);
											if (num10 < (uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + num18)
											{
												if (WriteFile(fileW1, &bootloaderCommand1, 65U, &num3, &overlapped1) != 0)
												{
													++num8;
													++num6;
													num10 = (uint) this.bytesPerPacket / (uint) this.bytesPerAddress + num10;
												}
												else if (Marshal.GetLastWin32Error() == 997)
												{
													++num8;
													++num6;
													num10 = (uint) this.bytesPerPacket / (uint) this.bytesPerAddress + num10;
												}
												else
													goto label_51;
											}
										}
										if (overlapped2.Internal != STATUS_PENDING && num8 < 10U)
										{
											num2 = 0;
											^(sbyte&) ((IntPtr) &bootloaderCommand2 + 1) = 7;
											^(int&) ((IntPtr) &bootloaderCommand2 + 2) = (int) num10;
											^(sbyte&) ((IntPtr) &bootloaderCommand2 + 6) = this.bytesPerPacket;
											^(sbyte&) @bootloaderCommand2 = (sbyte) 0;
											uint num13 = (uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 5);
											byte bytesPerAddress2 = this.bytesPerAddress;
											int num16 = (int) this.bytesPerPacket / (int) bytesPerAddress2;
											if (num10 + (uint) num16 > (uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + num13)
											{
												uint num17 = (uint) (num16 - *(int*) (num9 + (IntPtr) Form1.memoryRegions + 5));
												bytesPerAddress2 = this.bytesPerAddress;
												^(sbyte&) ((IntPtr) &bootloaderCommand2 + 6) = (sbyte) ((int) this.bytesPerPacket - ((int) num17 - *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + (int) num10) * (int) bytesPerAddress2);
											}
											if ((int) ^(byte&) ((IntPtr) &bootloaderCommand1 + 6) % (int) bytesPerAddress2 != 0)
											{
												int num17 = (int) ^(byte&) ((IntPtr) &bootloaderCommand1 + 6) % (int) this.bytesPerAddress;
												do
												{
													^(sbyte&) ((IntPtr) &bootloaderCommand2 + 6) = (sbyte) ((int) ^(byte&) ((IntPtr) &bootloaderCommand2 + 6) + 1);
												}
												while (num17 != 0);
											}
											overlapped2.Internal = 0;
											overlapped2.InternalHigh = 0;
											overlapped2.Offset = 0;
											overlapped2.OffsetHigh = 0;
											overlapped2.hEvent = eventW2;
											uint num18 = (uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 5);
											if (num10 < (uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + num18)
											{
												if (WriteFile(fileW1, &bootloaderCommand2, 65U, &num4, &overlapped2) != 0)
												{
													++num8;
													++num6;
													num10 = (uint) this.bytesPerPacket / (uint) this.bytesPerAddress + num10;
												}
												else if (Marshal.GetLastWin32Error() == 997)
												{
													++num8;
													++num6;
													num10 = (uint) this.bytesPerPacket / (uint) this.bytesPerAddress + num10;
												}
												else
													goto label_52;
											}
										}
									}
									while (overlapped3.Internal == STATUS_PENDING);
									num2 = 0;
									--num8;
									++num7;
									byte* numPtr = (byte*) ((^(int&) ((IntPtr) &bootloaderCommand3 + 2) - *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1)) * (int) this.bytesPerAddress + (IntPtr) memoryRegion);
									byte num19 = 0;
									if (0U < (uint) ^(byte&) ((IntPtr) &bootloaderCommand3 + 6))
									{
										do
										{
											*numPtr = ^(byte&) ((int) num19 - (int) ^(byte&) ((IntPtr) &bootloaderCommand3 + 6) + ((IntPtr) &bootloaderCommand3 + 65));
											++numPtr;
											++num19;
										}
										while ((uint) num19 < (uint) ^(byte&) ((IntPtr) &bootloaderCommand3 + 6));
									}
								}
								while (num8 <= 0U);
								overlapped3.Internal = 0;
								overlapped3.InternalHigh = 0;
								overlapped3.Offset = 0;
								overlapped3.OffsetHigh = 0;
								overlapped3.hEvent = eventW3;
								^(sbyte&) @bootloaderCommand3 = (sbyte) 0;
							}
							while (ReadFile(fileW2, &bootloaderCommand3, 65U, &num5, &overlapped3) != 0 || Marshal.GetLastWin32Error() == 997);
							goto label_53;
label_48:
							++region;
						}
						while ((uint) region < (uint) this.memoryRegionsDetected);
						goto label_54;
label_49:
						this.enablePrint = true;
						this.ReadThreadResults = (byte) 2;
						this.progressStatus = (byte) 100;
						CloseHandle(fileW1);
						CloseHandle(fileW2);
						return;
label_50:
						this.enablePrint = true;
						this.ReadThreadResults = (byte) 2;
						this.progressStatus = (byte) 100;
						CloseHandle(fileW1);
						CloseHandle(fileW2);
						return;
label_51:
						this.enablePrint = true;
						this.ReadThreadResults = (byte) 2;
						this.progressStatus = (byte) 100;
						CloseHandle(fileW1);
						CloseHandle(fileW2);
						return;
label_52:
						this.enablePrint = true;
						this.ReadThreadResults = (byte) 2;
						this.progressStatus = (byte) 100;
						CloseHandle(fileW1);
						CloseHandle(fileW2);
						return;
label_53:
						this.enablePrint = true;
						this.ReadThreadResults = (byte) 2;
						this.progressStatus = (byte) 100;
						CloseHandle(fileW1);
						CloseHandle(fileW2);
						return;
					}
label_54:
					this.enablePrint = true;
					this.ReadThreadResults = (byte) 1;
					this.progressStatus = (byte) 100;
					CloseHandle(fileW1);
					CloseHandle(fileW2);
				}
			}
		}

		private unsafe void VerifyThreadStart()
		{

			_BOOTLOADER_COMMAND bootloaderCommand1 = {0};
			_BOOTLOADER_COMMAND bootloaderCommand2 = {0};
			_BOOTLOADER_COMMAND bootloaderCommand3 = {0};
			uint num1 = GetTickCount();
			int num2 = 0;
			uint num3 = 0;
			uint num4 = 0;
			uint num5 = 0;
			uint num6 = 0;
			uint num7 = 0;
			uint num8 = 0;
			void* eventW1 = CreateEventW(NULL, 1, 1, L"WriteEvent");
			void* eventW2 = CreateEventW(NULL, 1, 1, L"WriteEvent2");
			void* eventW3 = CreateEventW(NULL, 1, 1, L"ReadEvent");
			_OVERLAPPED overlapped1 = {
				.Internal = 0,
				.InternalHigh = 0,
				.Offset = 0,
				.OffsetHigh = 0,
				.hEvent = eventW1;
			};
			_OVERLAPPED overlapped2 = {
				.Internal = 0,
				.InternalHigh = 0,
				.Offset = 0,
				.OffsetHigh = 0,
				.hEvent = eventW2;
			};
			_OVERLAPPED overlapped3 = {
				.Internal = 0,
				.InternalHigh = 0,
				.Offset = 0,
				.OffsetHigh = 0,
				.hEvent = eventW3;
			};
			SetEvent(eventW3);
			SetEvent(eventW2);
			SetEvent(eventW1);
			void* fileW1 = CreateFileW((char*) ((IntPtr) HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt + 4), 1073741824U, 3U, NULL, 3U, 1073741824U, NULL);
			if (Marshal.GetLastWin32Error() != 0)
			{
				this.enablePrint = true;
				this.ReadThreadResults = 2;
				this.progressStatus = 100;
			}
			else
			{
				void* fileW2 = CreateFileW((char*) ((IntPtr) HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt + 4), 2147483648U, 3U, NULL, 3U, 1073741824U, NULL);
				if (Marshal.GetLastWin32Error() != 0)
				{
					this.enablePrint = true;
					this.ReadThreadResults = 3;
					this.progressStatus = 100;
					CloseHandle(fileW1);
				}
				else
				{
					byte region = 0;
					if (0U < (uint) this.memoryRegionsDetected)
					{
						do
						{
							if (this.ckbox_ConfigWordProgramming.Checked || (int) *(byte*) ((IntPtr) Form1.memoryRegions + (int) region * 9) != 3)
							{
								int num9 = (int) region * 9;
								uint num10 = (uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1);
								_MEMORY_REGION* memoryRegions = Form1.memoryRegions;
								byte* memoryRegion = this.getMemoryRegion(region);
								^(sbyte&) ((IntPtr) &bootloaderCommand1 + 1) = 7;
								^(int&) ((IntPtr) &bootloaderCommand1 + 2) = (int) num10;
								^(sbyte&) ((IntPtr) &bootloaderCommand1 + 6) = this.bytesPerPacket;
								^(sbyte&) @bootloaderCommand1 = (sbyte) 0;
								_MEMORY_REGION* memoryRegionPtr1 = (_MEMORY_REGION*) (num9 + (IntPtr) Form1.memoryRegions + 5);
								byte bytesPerAddress1 = this.bytesPerAddress;
								int num11 = (int) this.bytesPerPacket / (int) bytesPerAddress1;
								if ((uint) num11 + num10 > (uint) (*(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + *(int*) memoryRegionPtr1))
								{
									uint num12 = (uint) (num11 - *(int*) (num9 + (IntPtr) Form1.memoryRegions + 5));
									bytesPerAddress1 = this.bytesPerAddress;
									^(sbyte&) ((IntPtr) &bootloaderCommand1 + 6) = (sbyte) ((int) this.bytesPerPacket - ((int) num12 - *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + (int) num10) * (int) bytesPerAddress1);
								}
								if ((int) ^(byte&) ((IntPtr) &bootloaderCommand1 + 6) % (int) bytesPerAddress1 != 0)
								{
									byte bytesPerAddress2 = this.bytesPerAddress;
									do
									{
										^(sbyte&) ((IntPtr) &bootloaderCommand1 + 6) = (sbyte) ((int) ^(byte&) ((IntPtr) &bootloaderCommand1 + 6) + 1);
									}
									while ((int) ^(byte&) ((IntPtr) &bootloaderCommand1 + 6) % (int) bytesPerAddress2 != 0);
								}
								_MEMORY_REGION* memoryRegionPtr2 = (_MEMORY_REGION*) (num9 + (IntPtr) Form1.memoryRegions + 5);
								if (num10 < (uint) (*(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + *(int*) memoryRegionPtr2))
								{
									overlapped1.Internal = 0;
									overlapped1.InternalHigh = 0;
									overlapped1.Offset = 0;
									overlapped1.OffsetHigh = 0;
									overlapped1.hEvent = eventW1;
									if (WriteFile(fileW1, &bootloaderCommand1, 65U, &num3, &overlapped1) != 0)
									{
										num8 = 1U;
										num10 = (uint) this.bytesPerPacket / (uint) this.bytesPerAddress + num10;
										++num6;
									}
									else if (Marshal.GetLastWin32Error() == 997)
									{
										num8 = 1U;
										++num6;
										num10 = (uint) this.bytesPerPacket / (uint) this.bytesPerAddress + num10;
									}
									else
										goto label_51;
									overlapped3.Internal = 0;
									overlapped3.InternalHigh = 0;
									overlapped3.Offset = 0;
									overlapped3.OffsetHigh = 0;
									overlapped3.hEvent = eventW3;
									SetEvent(eventW3);
									^(sbyte&) @bootloaderCommand3 = (sbyte) 0;
									if (ReadFile(fileW2, &bootloaderCommand3, 65U, &num5, &overlapped3) == 0 && Marshal.GetLastWin32Error() != 997)
										goto label_52;
								}
								do
								{
									do
									{
										do
										{
											if (num8 == 0)
											{
												_MEMORY_REGION* memoryRegionPtr3 = (_MEMORY_REGION*) (num9 + (IntPtr) Form1.memoryRegions + 5);
												if (num10 >= (uint) (*(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + *(int*) memoryRegionPtr3))
													goto label_50;
											}
											this.progressStatus = (byte) ((uint) (((int) num10 - *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1)) * 100) / (uint) *(int*) (num9 + (IntPtr) Form1.memoryRegions + 5));
											Sleep(0U);
											uint tickCount = GetTickCount();
											if (tickCount - num1 > 10000U)
											{
												if (num2 != 1)
												{
													num1 = tickCount;
													num2 = 1;
												}
												else
													goto label_53;
											}
											if (overlapped1.Internal != STATUS_PENDING && num8 < 10U)
											{
												num2 = 0;
												^(sbyte&) ((IntPtr) &bootloaderCommand1 + 1) = (sbyte) 7;
												^(int&) ((IntPtr) &bootloaderCommand1 + 2) = (int) num10;
												^(sbyte&) ((IntPtr) &bootloaderCommand1 + 6) = (sbyte) this.bytesPerPacket;
												^(sbyte&) @bootloaderCommand1 = (sbyte) 0;
												_MEMORY_REGION* memoryRegionPtr3 = (_MEMORY_REGION*) (num9 + (IntPtr) Form1.memoryRegions + 5);
												byte bytesPerAddress2 = this.bytesPerAddress;
												int num12 = (int) this.bytesPerPacket / (int) bytesPerAddress2;
												if ((uint) num12 + num10 > (uint) (*(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + *(int*) memoryRegionPtr3))
												{
													uint num13 = (uint) (num12 - *(int*) (num9 + (IntPtr) Form1.memoryRegions + 5));
													bytesPerAddress2 = this.bytesPerAddress;
													^(sbyte&) ((IntPtr) &bootloaderCommand1 + 6) = (sbyte) ((int) this.bytesPerPacket - ((int) num13 - *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + (int) num10) * (int) bytesPerAddress2);
												}
												if ((int) ^(byte&) ((IntPtr) &bootloaderCommand1 + 6) % (int) bytesPerAddress2 != 0)
												{
													byte bytesPerAddress3 = this.bytesPerAddress;
													do
													{
														^(sbyte&) ((IntPtr) &bootloaderCommand1 + 6) = (sbyte) ((int) ^(byte&) ((IntPtr) &bootloaderCommand1 + 6) + 1);
													}
													while ((int) ^(byte&) ((IntPtr) &bootloaderCommand1 + 6) % (int) bytesPerAddress3 != 0);
												}
												overlapped1.Internal = 0;
												overlapped1.InternalHigh = 0;
												overlapped1.Offset = 0;
												overlapped1.OffsetHigh = 0;
												overlapped1.hEvent = eventW1;
												_MEMORY_REGION* memoryRegionPtr4 = (_MEMORY_REGION*) (num9 + (IntPtr) Form1.memoryRegions + 5);
												if (num10 < (uint) (*(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + *(int*) memoryRegionPtr4))
												{
													if (WriteFile(fileW1, &bootloaderCommand1, 65U, &num3, &overlapped1) != 0)
													{
														++num8;
														++num6;
														num10 = (uint) this.bytesPerPacket / (uint) this.bytesPerAddress + num10;
													}
													else if (Marshal.GetLastWin32Error() == 997)
													{
														++num8;
														++num6;
														num10 = (uint) this.bytesPerPacket / (uint) this.bytesPerAddress + num10;
													}
													else
														goto label_54;
												}
											}
											if (overlapped2.Internal != STATUS_PENDING && num8 < 10U)
											{
												num2 = 0;
												^(sbyte&) ((IntPtr) &bootloaderCommand2 + 1) = 7;
												^(int&) ((IntPtr) &bootloaderCommand2 + 2) = num10;
												^(sbyte&) ((IntPtr) &bootloaderCommand2 + 6) = this.bytesPerPacket;
												^(sbyte&) @bootloaderCommand2 = 0;
												_MEMORY_REGION* memoryRegionPtr3 = (_MEMORY_REGION*) (num9 + (IntPtr) Form1.memoryRegions + 5);
												byte bytesPerAddress2 = this.bytesPerAddress;
												int num12 = (int) this.bytesPerPacket / (int) bytesPerAddress2;
												if ((uint) num12 + num10 > (uint) (*(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + *(int*) memoryRegionPtr3))
												{
													uint num13 = (uint) (num12 - *(int*) (num9 + (IntPtr) Form1.memoryRegions + 5));
													bytesPerAddress2 = this.bytesPerAddress;
													^(sbyte&) ((IntPtr) &bootloaderCommand2 + 6) = (sbyte) ((int) this.bytesPerPacket - ((int) num13 - *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + (int) num10) * (int) bytesPerAddress2);
												}
												if ((int) ^(byte&) ((IntPtr) &bootloaderCommand1 + 6) % (int) bytesPerAddress2 != 0)
												{
													int num13 = (int) ^(byte&) ((IntPtr) &bootloaderCommand1 + 6) % (int) this.bytesPerAddress;
													do
													{
														^(sbyte&) ((IntPtr) &bootloaderCommand2 + 6) = (sbyte) ((int) ^(byte&) ((IntPtr) &bootloaderCommand2 + 6) + 1);
													}
													while (num13 != 0);
												}
												overlapped2.Internal = 0;
												overlapped2.InternalHigh = 0;
												overlapped2.Offset = 0;
												overlapped2.OffsetHigh = 0;
												overlapped2.hEvent = eventW2;
												_MEMORY_REGION* memoryRegionPtr4 = (_MEMORY_REGION*) (num9 + (IntPtr) Form1.memoryRegions + 5);
												if (num10 < (uint) (*(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) + *(int*) memoryRegionPtr4))
												{
													if (WriteFile(fileW1, &bootloaderCommand2, 65U, &num4, &overlapped2) != 0)
													{
														++num8;
														++num6;
														num10 = (uint) this.bytesPerPacket / (uint) this.bytesPerAddress + num10;
													}
													else if (Marshal.GetLastWin32Error() == 997)
													{
														++num8;
														++num6;
														num10 = (uint) this.bytesPerPacket / (uint) this.bytesPerAddress + num10;
													}
													else
														goto label_55;
												}
											}
										}
										while (overlapped3.Internal == STATUS_PENDING);
										num2 = 0;
										--num8;
										++num7;
										byte bytesPerAddress4 = this.bytesPerAddress;
										byte* numPtr = (byte*) ((^(int&) ((IntPtr) &bootloaderCommand3 + 2) - *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1)) * (int) bytesPerAddress4 + (IntPtr) memoryRegion);
										byte num14 = 0;
										if (0U < (uint) ^(byte&) ((IntPtr) &bootloaderCommand3 + 6))
										{
											do
											{
												byte num12 = *numPtr;
												++numPtr;
												if ((int) num12 == (int) ^(byte&) ((int) num14 - (int) ^(byte&) ((IntPtr) &bootloaderCommand3 + 6) + ((IntPtr) &bootloaderCommand3 + 65)) || (int) bytesPerAddress4 == 2 && ((int) num14 + 1) % 4 == 0)
													++num14;
												else
													goto label_56;
											}
											while ((uint) num14 < (uint) ^(byte&) ((IntPtr) &bootloaderCommand3 + 6));
										}
									}
									while (num8 <= 0U);
									overlapped3.Internal = 0;
									overlapped3.InternalHigh = 0;
									overlapped3.Offset = 0;
									overlapped3.OffsetHigh = 0;
									overlapped3.hEvent = eventW3;
									^(sbyte&) @bootloaderCommand3 = (sbyte) 0;
								}
								while (ReadFile(fileW2, &bootloaderCommand3, 65U, &num5, &overlapped3) != 0 || Marshal.GetLastWin32Error() == 997);
								goto label_57;
							}
label_50:
							++region;
						}
						while ((uint) region < (uint) this.memoryRegionsDetected);
						goto label_58;
label_51:
						this.enablePrint = true;
						this.ReadThreadResults = 2;
						this.progressStatus = 100;
						CloseHandle(fileW1);
						CloseHandle(fileW2);
						return;
label_52:
						this.enablePrint = true;
						this.ReadThreadResults = 2;
						this.progressStatus = 100;
						CloseHandle(fileW1);
						CloseHandle(fileW2);
						return;
label_53:
						this.enablePrint = true;
						this.ReadThreadResults = 2;
						this.progressStatus = 100;
						CloseHandle(fileW1);
						CloseHandle(fileW2);
						return;
label_54:
						this.enablePrint = true;
						this.ReadThreadResults = 2;
						this.progressStatus = 100;
						CloseHandle(fileW1);
						CloseHandle(fileW2);
						return;
label_55:
						this.enablePrint = true;
						this.ReadThreadResults = 2;
						this.progressStatus = 100;
						CloseHandle(fileW1);
						CloseHandle(fileW2);
						return;
label_56:
						this.enablePrint = true;
						this.VerifyThreadResults = 4;
						this.progressStatus = 100;
						CloseHandle(fileW1);
						CloseHandle(fileW2);
						return;
label_57:
						this.enablePrint = true;
						this.ReadThreadResults = 2;
						this.progressStatus = 100;
						CloseHandle(fileW1);
						CloseHandle(fileW2);
						return;
					}
label_58:
					this.enablePrint = true;
					this.VerifyThreadResults = 1;
					this.progressStatus = 100;
					CloseHandle(fileW1);
					CloseHandle(fileW2);
				}
			}
		}

		private void btn_Verify_Click(object sender, EventArgs e)
		{
			this.DisableButtons();
			this.bootloaderState = 3;
			this.VerifyThreadResults = 0;
			Thread verifyThread = this.VerifyThread;
			if (verifyThread != null && verifyThread.IsAlive)
				return;
			this.listBox1.Items.Clear();
			this.enablePrint = true;
			Thread thread = new Thread(new ThreadStart(this.VerifyThreadStart));
			this.VerifyThread = thread;
			thread.Start();
		}

		private unsafe void btn_OpenHexFile_Click(object sender, EventArgs e)
		{
			FileStream fileStream = null;
			StreamReader streamReader = null;
			Stream stream = null;
			uint num2 = 0;
			this.DisableButtons();
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Hex files (*.hex)|*.hex|All files (*.*)|*.*";
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;
			uint exceptionCode;
			uint num3;

label_22:
			bool flag1 = false;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				stream = openFileDialog.OpenFile();
				if (stream != null)
				{
					try
					{
						fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
						streamReader = new StreamReader(fileStream);
					}
					catch
					{
						if (fileStream != null)
						{
							fileStream.Close();
							fileStream.Dispose();
						}
						stream.Close();
						stream.Dispose();
						return;
					}
					bool flag2 = false;
label_36:
					uint hex1;
					string s;
					uint num5;
					byte num6;
					byte num7;
					do
					{
						do
						{
							string str1;
							do
							{
								string str2 = streamReader.ReadLine();
								if (str2 != null && !flag2)
									str1 = str2.Trim();
								else
									goto label_92;
							}
							while (str1.Length <= 0);
							if ((int) str1[0] != 58)
								flag1 = true;
							else
								str1 = str1.Substring(1, str1.Length - 1);
							hex1 = this.StringToHex(str1.Substring(0, 2));
							str1.Substring(2, 4);
							uint hex2 = this.StringToHex(str1.Substring(2, 4));
							uint hex3 = this.StringToHex(str1.Substring(6, 2));
							s = str1.Substring(8, (int) hex1 << 1);
							uint hex4 = this.StringToHex(str1.Substring((int) hex1 + 4 << 1, 2));
							uint num4 = 0;
							byte num8 = 0;
							if (0U < hex1 + 4U)
							{
								do
								{
									num4 = this.StringToHex(str1.Substring((int) num8 << 1, 2)) + num4;
									++num8;
								}
								while ((uint) num8 < hex1 + 4U);
							}
							if ((~(int) num4 + 1 & (int) byte.MaxValue) != (int) hex4)
							{
								this.enablePrint = true;
								this.listBox1.Items.Add((object) "ERROR: There is a checksum error in the hex file.");
								this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
								this.enablePrint = false;
								goto label_59;
							}
							else if (!flag1)
							{
								if ((int) hex3 != 0)
								{
									if ((int) hex3 != 1)
									{
										if ((int) hex3 == 4)
											num2 = this.StringToHex(s);
									}
									else
										flag2 = true;
								}
								else
								{
									num5 = num2 * 65536U + hex2;
									num6 = (byte) 0;
								}
							}
							else
								goto label_59;
						}
						while (0U >= (uint) this.memoryRegionsDetected);
						do
						{
							Form1 form1 = this;
							int num4 = (int) num6;
							byte* memoryRegion = form1.getMemoryRegion((byte) num4);
							form1.pData = memoryRegion;
							int num8 = (int) num6 * 9;
							if (num5 >= (uint) *(int*) (num8 + (IntPtr) Form1.memoryRegions + 1) * (uint) this.bytesPerAddress)
							{
								_MEMORY_REGION* memoryRegionPtr = (_MEMORY_REGION*) (num8 + (IntPtr) Form1.memoryRegions + 5);
								if (num5 < (uint) (*(int*) (num8 + (IntPtr) Form1.memoryRegions + 1) + *(int*) memoryRegionPtr) * (uint) this.bytesPerAddress)
									goto label_55;
							}
							++num6;
						}
						while ((uint) num6 < (uint) this.memoryRegionsDetected);
						continue;
label_55:
						num7 = (byte) 0;
					}
					while (0U >= hex1);
					int num9 = (int) num6 * 9;
					do
					{
						_MEMORY_REGION* memoryRegions = Form1.memoryRegions;
						uint hex2 = this.StringToHex(s.Substring((int) num7 << 1, 2));
						byte* numPtr1 = (byte*) ((int) num7 - *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) * (int) this.bytesPerAddress + (IntPtr) this.pData + (int) num5);
						byte* numPtr2 = (byte*) ((*(int*) (num9 + (IntPtr) Form1.memoryRegions + 5) + 1) * (int) this.bytesPerAddress + (IntPtr) this.pData);
						if (numPtr1 < numPtr2)
						{
							*numPtr1 = (byte) hex2;
							++num7;
						}
						else
							break;
					}
					while ((uint) num7 < hex1);
					goto label_36;
label_59:
					if (fileStream != null)
					{
						fileStream.Close();
						fileStream.Dispose();
					}

					if (streamReader != null)
					{
						streamReader.Close();
						streamReader.Dispose();
					}

					if (stream == null)
						return;
					stream.Close();
					stream.Dispose();
					return;
label_92:
					if (!flag1)
					{
						this.gbol_SuccessProgram = false;
						this.ListBoxUpdate(4);
					}
					this.btn_ProgramVerify_restore = true;
					if (!this.ckbox_ConfigWordProgramming.Checked)
						this.btn_EraseDevice_restore = true;
					this.btn_ExportHex_restore = true;
					this.btn_Verify_restore = true;
				}
			}

			if (fileStream != null)
			{
				fileStream.Close();
				fileStream.Dispose();
			}

			if (streamReader != null)
			{
				streamReader.Close();
				streamReader.Dispose();
			}

			if (stream == null)
					return;
			stream.Close();
			stream.Dispose();
		}

		private unsafe void btn_ExportHex_Click(object sender, EventArgs e)
		{
			StreamWriter streamWriter = (StreamWriter) null;
			FileStream fileStream = (FileStream) null;
			int num1 = (int) __untypedstackalloc(___CxxQueryExceptionSize());
			this.DisableButtons();
			if (this.dialog_ExportHex.ShowDialog() != DialogResult.OK)
				return;
			sbyte* numPtr;
			try
			{
				streamWriter = new StreamWriter(this.dialog_ExportHex.FileName, false);
			}
			catch
			{
				if (this.enablePrint)
				{
					this.listBox1.Items.Add((object) new string(numPtr));
					this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
					this.enablePrint = false;
				}
				if (fileStream != null)
					fileStream.Dispose();
				return;
			}
			byte region = 0;
			if (0U < (uint) this.memoryRegionsDetected)
			{
				do
				{
					int num2 = (int) region * 9;
					uint input1 = (uint) *(int*) (num2 + (IntPtr) Form1.memoryRegions + 1) * (uint) this.bytesPerAddress;
					_MEMORY_REGION* memoryRegions = Form1.memoryRegions;
					byte* memoryRegion = this.getMemoryRegion(region);
					uint input2 = input1 >> 16;
					streamWriter.WriteLine(":02000004" + this.HexToString(input2, (byte) 2) + this.HexToString((uint) (byte) (~((int) (byte) input2 + (int) (byte) (input1 >> 24) + 6) + 1), (byte) 1));
					uint num3 = input2;
					while (true)
					{
						uint input3 = input1 >> 16;
						uint num4 = input3;
						if ((int) num4 != (int) num3)
							streamWriter.WriteLine(":02000004" + this.HexToString(input3, (byte) 2) + this.HexToString((uint) (byte) (~((int) (byte) input3 + (int) (byte) (input1 >> 24) + 6) + 1), (byte) 1));
						string str1 = ":";
						byte num5 = 16;
						_MEMORY_REGION* memoryRegionPtr1 = (_MEMORY_REGION*) (num2 + (IntPtr) Form1.memoryRegions + 5);
						if (input1 + 16U > (uint) (*(int*) (num2 + (IntPtr) Form1.memoryRegions + 1) + *(int*) memoryRegionPtr1) * (uint) this.bytesPerAddress)
						{
							_MEMORY_REGION* memoryRegionPtr2 = (_MEMORY_REGION*) (num2 + (IntPtr) Form1.memoryRegions + 5);
							num5 = (byte) ((*(int*) (num2 + (IntPtr) Form1.memoryRegions + 1) + *(int*) memoryRegionPtr2) * (int) this.bytesPerAddress - (int) input1);
						}
						string str2 = str1 + this.HexToString((uint) num5, (byte) 1) + this.HexToString(input1, (byte) 2);
						byte num6 = (byte) ((int) ~(byte) (input1 >> 8) + (int) (byte) ((int) ~(byte) input1 + (int) (byte) ((uint) ~num5 + 1U) + 1) + 1);
						string str3 = str2 + "00";
						byte num7 = 0;
						if (0U < (uint) num5)
						{
							do
							{
								byte num8 = *memoryRegion;
								++memoryRegion;
								str3 += this.HexToString((uint) num8, (byte) 1);
								num6 = (byte) ((int) num6 + (int) ~num8 + 1);
								++num7;
							}
							while ((uint) num7 < (uint) num5);
						}
						string str4 = str3 + this.HexToString((uint) num6, (byte) 1);
						streamWriter.WriteLine(str4);
						input1 = (uint) num5 + input1;
						_MEMORY_REGION* memoryRegionPtr3 = (_MEMORY_REGION*) (num2 + (IntPtr) Form1.memoryRegions + 5);
						if (input1 < (uint) (*(int*) (num2 + (IntPtr) Form1.memoryRegions + 1) + *(int*) memoryRegionPtr3) * (uint) this.bytesPerAddress)
							num3 = num4;
						else
							break;
					}
					++region;
				}
				while ((uint) region < (uint) this.memoryRegionsDetected);
			}
			streamWriter.WriteLine(":00000001FF");
			streamWriter.Close();
			if (!this.enablePrint)
				return;
			this.listBox1.Items.Add((object) "Export completed successfully");
			this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
			this.enablePrint = false;
		}

		private void btn_ProgramVerify_Click(object sender, EventArgs e)
		{
			this.DisableButtons();
			this.bootloaderState = (byte) 1;
			this.ProgramThreadResults = (byte) 0;
			Thread programThread = this.ProgramThread;
			if (programThread != null && programThread.IsAlive)
				return;
			this.listBox1.Items.Clear();
			this.enablePrint = true;
			Thread thread = new Thread(new ThreadStart(this.ProgramThreadStart));
			this.ProgramThread = thread;
			thread.Start();
		}

		private unsafe void ProgramThreadStart()
		{
			_BOOTLOADER_COMMAND bootloaderCommand1;
			^(sbyte&) @bootloaderCommand1 = (sbyte) 0;
			__memset((_BOOTLOADER_COMMAND&) ((IntPtr) &bootloaderCommand1 + 1), 0, 65);
			_BOOTLOADER_COMMAND bootloaderCommand2;
			^(sbyte&) @bootloaderCommand2 = (sbyte) 0;
			__memset((_BOOTLOADER_COMMAND&) ((IntPtr) &bootloaderCommand2 + 1), 0, 65);
			uint num1 = 0;
			uint num2 = 0;
			void* fileW1 = CreateFileW((char*) ((IntPtr) HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt + 4), 1073741824U, 3U, NULL, 3U, 0U, NULL);
			HIDBootLoader.ErrorStatusWrite = (uint) Marshal.GetLastWin32Error();
			void* fileW2 = CreateFileW((char*) ((IntPtr) HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt + 4), 2147483648U, 3U, NULL, 3U, 0U, NULL);
			HIDBootLoader.ErrorStatusRead = (uint) Marshal.GetLastWin32Error();
			bool flag1 = false;
			bool flag2 = false;
			this.enablePrint = true;
			this.ProgramThreadResults = (byte) 5;
			this.progressStatus = (byte) 0;
			^(sbyte&) @bootloaderCommand1 = (sbyte) 0;
			^(sbyte&) ((IntPtr) &bootloaderCommand1 + 1) = (sbyte) 4;
			WriteFile(fileW1, &bootloaderCommand1, 65U, &num1, NULL);
			if (Marshal.GetLastWin32Error() == 0)
			{
				^(sbyte&) @bootloaderCommand1 = (sbyte) 0;
				^(sbyte&) ((IntPtr) &bootloaderCommand1 + 1) = (sbyte) 2;
				this.progressStatus = (byte) 50;
				WriteFile(fileW1, &bootloaderCommand1, 65U, &num1, NULL);
				if (Marshal.GetLastWin32Error() != 0)
				{
					this.enablePrint = true;
					this.ProgramThreadResults = (byte) 2;
				}
				else
				{
					ReadFile(fileW2, &bootloaderCommand2, 65U, &num2, NULL);
					if (Marshal.GetLastWin32Error() != 0)
					{
						this.enablePrint = true;
						this.ProgramThreadResults = (byte) 3;
					}
					else
					{
						this.enablePrint = true;
						this.ProgramThreadResults = (byte) 6;
						if (!this.ckbox_ConfigWordProgramming.Checked)
							flag1 = true;
						while (!flag1 || !flag2)
						{
							byte region = 0;
							if (0U < (uint) this.memoryRegionsDetected)
							{
								do
								{
									int num3;
									if (!flag1)
									{
										num3 = (int) region * 9;
										if ((int) *(byte*) ((IntPtr) Form1.memoryRegions + num3) != 3)
											goto label_40;
									}
									else
									{
										num3 = (int) region * 9;
										if ((int) *(byte*) ((IntPtr) Form1.memoryRegions + num3) == 3)
											goto label_40;
									}
									uint num4 = (uint) *(int*) (num3 + (IntPtr) Form1.memoryRegions + 1);
									_MEMORY_REGION* memoryRegions = Form1.memoryRegions;
									byte* memoryRegion = this.getMemoryRegion(region);
									bool flag3 = true;
									bool flag4 = false;
									byte num5 = 1;
									_MEMORY_REGION* memoryRegionPtr1 = (_MEMORY_REGION*) (num3 + (IntPtr) Form1.memoryRegions + 5);
									if (num4 < (uint) (*(int*) (num3 + (IntPtr) Form1.memoryRegions + 1) + *(int*) memoryRegionPtr1))
									{
										_MEMORY_REGION* memoryRegionPtr2;
										do
										{
											^(sbyte&) @bootloaderCommand1 = (sbyte) 0;
											^(sbyte&) ((IntPtr) &bootloaderCommand1 + 1) = (sbyte) 5;
											^(int&) ((IntPtr) &bootloaderCommand1 + 2) = (int) num4;
											this.progressStatus = (byte) ((uint) (((int) num4 - *(int*) (num3 + (IntPtr) Form1.memoryRegions + 1)) * 100) / (uint) *(int*) (num3 + (IntPtr) Form1.memoryRegions + 5));
											byte num6 = 0;
											if (0U < (uint) this.bytesPerPacket)
											{
												do
												{
													byte num7 = *memoryRegion;
													++memoryRegion;
													^(sbyte&) ((int) num6 - (int) this.bytesPerPacket + ((IntPtr) &bootloaderCommand1 + 65)) = (sbyte) num7;
													if ((int) num7 != (int) byte.MaxValue)
													{
														if ((int) this.bytesPerAddress == 2)
														{
															if (((int) num4 & 1) != 0)
															{
																if ((int) num5 != 2)
																	flag3 = false;
															}
															else
																flag3 = false;
														}
														else
															flag3 = false;
													}
													if ((int) num5 == (int) this.bytesPerAddress)
													{
														++num4;
														num5 = (byte) 1;
													}
													else
														++num5;
													_MEMORY_REGION* memoryRegionPtr3 = (_MEMORY_REGION*) (num3 + (IntPtr) Form1.memoryRegions + 5);
													if (num4 < (uint) (*(int*) (num3 + (IntPtr) Form1.memoryRegions + 1) + *(int*) memoryRegionPtr3))
														++num6;
													else
														goto label_26;
												}
												while ((uint) num6 < (uint) this.bytesPerPacket);
												goto label_31;
label_26:
												++num6;
												byte num8 = 0;
												do
												{
													if ((uint) num8 < (uint) num6)
													{
														^(sbyte&) ((IntPtr) &bootloaderCommand1 + 64 - (int) num8) = (sbyte) ^(byte&) ((int) num6 - (int) num8 - (int) this.bytesPerPacket + ((IntPtr) &bootloaderCommand1 + 64));
													}
													else
													{
														^(sbyte&) ((IntPtr) &bootloaderCommand1 + 64 - (int) num8) = (sbyte) 0;
													}
													++num8;
												}
												while ((uint) num8 < 58U);
											}
label_31:
											^(sbyte&) ((IntPtr) &bootloaderCommand1 + 6) = (sbyte) num6;
											if (!flag3)
											{
												if (flag4)
												{
													_BOOTLOADER_COMMAND bootloaderCommand3;
													^(sbyte&) @bootloaderCommand3 = (sbyte) 0;
													__memset((_BOOTLOADER_COMMAND&) ((IntPtr) &bootloaderCommand3 + 1), 0, 65);
													^(sbyte&) ((IntPtr) &bootloaderCommand3 + 1) = (sbyte) 6;
													WriteFile(fileW1, &bootloaderCommand3, 65U, &num1, NULL);
													if (Marshal.GetLastWin32Error() == 0)
														flag4 = false;
													else
														goto label_45;
												}
												WriteFile(fileW1, &bootloaderCommand1, 65U, &num1, NULL);
												if (Marshal.GetLastWin32Error() == 0)
													flag3 = true;
												else
													goto label_46;
											}
											else
											{
												flag4 = true;
												flag3 = true;
											}
											memoryRegionPtr2 = (_MEMORY_REGION*) (num3 + (IntPtr) Form1.memoryRegions + 5);
										}
										while (num4 < (uint) (*(int*) (num3 + (IntPtr) Form1.memoryRegions + 1) + *(int*) memoryRegionPtr2));
									}
									^(sbyte&) @bootloaderCommand1 = (sbyte) 0;
									^(sbyte&) ((IntPtr) &bootloaderCommand1 + 1) = (sbyte) 6;
									WriteFile(fileW1, &bootloaderCommand1, 65U, &num1, NULL);
									if (Marshal.GetLastWin32Error() != 0)
										goto label_47;
label_40:
									++region;
								}
								while ((uint) region < (uint) this.memoryRegionsDetected);
								goto label_41;
label_45:
								this.enablePrint = true;
								this.ProgramThreadResults = (byte) 2;
								return;
label_46:
								this.enablePrint = true;
								this.ProgramThreadResults = (byte) 2;
								return;
label_47:
								this.enablePrint = true;
								this.ProgramThreadResults = (byte) 2;
								return;
							}
label_41:
							if (!flag1)
								flag1 = true;
							else
								flag2 = true;
						}
						this.enablePrint = true;
						this.ProgramThreadResults = (byte) 1;
					}
				}
			}
			else
			{
				this.enablePrint = true;
				this.ProgramThreadResults = (byte) 2;
			}
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 537 && ((int) m.WParam == 32768 || (int) m.WParam == 32771 || ((int) m.WParam == 32772 || (int) m.WParam == 24)))
				this.MyCallBackOnWM_DEVICECHANGE(ref m);
			base.WndProc(ref m);
		}

		private unsafe void MyCallBackOnWM_DEVICECHANGE(ref Message m)
		{
			int wparam1 = (int) m.WParam;
			int wparam2 = (int) m.WParam;
			int wparam3 = (int) m.WParam;
			HIDBootLoader.Status = this.TryToFindHIDDeviceFromVIDPID() ? 1 : 0;
			if (HIDBootLoader.Status == 1)
			{
				if (HIDBootLoader.MyDeviceAttachedStatus != 0)
					return;
				CreateFileW((char*) ((IntPtr) HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt + 4), 1073741824U, 3U, NULL, 3U, 0U, NULL);
				HIDBootLoader.ErrorStatusWrite = (uint) Marshal.GetLastWin32Error();
				CreateFileW((char*) ((IntPtr) HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt + 4), 2147483648U, 3U, NULL, 3U, 0U, NULL);
				HIDBootLoader.ErrorStatusRead = (uint) Marshal.GetLastWin32Error();
				if ((int) HIDBootLoader.ErrorStatusRead == 0 && (int) HIDBootLoader.ErrorStatusWrite == 0)
				{
					this.DeviceAttached();
					HIDBootLoader.MyDeviceAttachedStatus = 1;
				}
				else
				{
					HIDBootLoader.MyDeviceAttachedStatus = 0;
					this.DeviceRemoved();
				}
			}
			else
			{
				HIDBootLoader.MyDeviceAttachedStatus = 0;
				this.DeviceRemoved();
				CloseHandle(-1);
				CloseHandle(-1);
			}
		}

		[return: MarshalAs(UnmanagedType.U1)]
		private unsafe bool TryToFindHIDDeviceFromVIDPID()
		{
			_SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData = (_SP_DEVICE_INTERFACE_DATA*) @new(28U);
			uint MemberIndex = 0;
			uint DeviceInterfaceDetailDataSize = 0;
			string str1 = "Vid_04d8&Pid_003c";
			void* classDevsUm = SetupDiGetClassDevsUM(&HIDBootLoader.InterfaceClassGuid, NULL, NULL, 18U);
			*(int*) DeviceInterfaceData = 28;
			if (SetupDiEnumDeviceInterfacesUM(classDevsUm, NULL, &HIDBootLoader.InterfaceClassGuid, 0U, DeviceInterfaceData) != 0)
			{
				while (259 != Marshal.GetLastWin32Error())
				{
					_SP_DEVINFO_DATA spDevinfoData;
					^(int&) @spDevinfoData = 28;
					if (SetupDiEnumDeviceInfoUM(classDevsUm, MemberIndex, &spDevinfoData) != 0)
					{
						uint num;
						uint PropertyBufferSize;
						SetupDiGetDeviceRegistryPropertyUM(classDevsUm, &spDevinfoData, 1U, &num, NULL, 0U, &PropertyBufferSize);
						byte* PropertyBuffer = (byte*) malloc(PropertyBufferSize);
						if ((IntPtr) PropertyBuffer != IntPtr.Zero)
						{
							if (SetupDiGetDeviceRegistryPropertyUM(classDevsUm, &spDevinfoData, 1U, &num, PropertyBuffer, PropertyBufferSize, NULL) != 0)
							{
								string str2 = new string((char*) PropertyBuffer);
								free(PropertyBuffer);
								string lowerInvariant = str2.ToLowerInvariant();
								str1 = str1.ToLowerInvariant();
								if (!lowerInvariant.Contains(str1))
								{
									++MemberIndex;
									if ((int) MemberIndex != 10000000)
									{
										*(int*) DeviceInterfaceData = 28;
										if (SetupDiEnumDeviceInterfacesUM(classDevsUm, NULL, &HIDBootLoader.InterfaceClassGuid, MemberIndex, DeviceInterfaceData) == 0)
											goto label_18;
									}
									else
									{
										SetupDiDestroyDeviceInfoListUM(classDevsUm);
										return false;
									}
								}
								else
								{
									*(int*) HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt = 6;
									SetupDiGetDeviceInterfaceDetailUM(classDevsUm, DeviceInterfaceData, NULL, 0U, &DeviceInterfaceDetailDataSize, NULL);
									HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt = (_SP_DEVICE_INTERFACE_DETAIL_DATA_W*) malloc(DeviceInterfaceDetailDataSize);
									if ((IntPtr) HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt == IntPtr.Zero)
									{
										SetupDiDestroyDeviceInfoListUM(classDevsUm);
										return false;
									}
									*(int*) HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt = 6;
									if (SetupDiGetDeviceInterfaceDetailUM(classDevsUm, DeviceInterfaceData, HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt, DeviceInterfaceDetailDataSize, NULL, NULL) == 0)
									{
										SetupDiDestroyDeviceInfoListUM(classDevsUm);
										return false;
									}
									SetupDiDestroyDeviceInfoListUM(classDevsUm);
									return true;
								}
							}
							else
							{
								SetupDiDestroyDeviceInfoListUM(classDevsUm);
								return false;
							}
						}
						else
						{
							SetupDiDestroyDeviceInfoListUM(classDevsUm);
							return false;
						}
					}
					else
					{
						SetupDiDestroyDeviceInfoListUM(classDevsUm);
						return false;
					}
				}
				SetupDiDestroyDeviceInfoListUM(classDevsUm);
				return false;
			}
label_18:
			Marshal.GetLastWin32Error();
			SetupDiDestroyDeviceInfoListUM(classDevsUm);
			return false;
		}

		private void DeviceAttached()
		{
			this.bootloaderState = (byte) 0;
			this.QueryThreadResults = (byte) 0;
			this.deviceAttached = true;
			this.listBox1.Items.Clear();
			this.ListBoxUpdate(2);
			Thread queryThread = this.QueryThread;
			if (queryThread != null && queryThread.IsAlive)
				return;
			Thread thread = new Thread(new ThreadStart(this.QueryThreadStart));
			this.QueryThread = thread;
			thread.Start();
		}

		private unsafe void DeviceRemoved()
		{
			this.listBox1.Items.Clear();
			if (this.deviceAttached)
			{
				if (this.gbol_SuccessProgram)
					this.ListBoxUpdate(3);
				else
					this.ListBoxUpdate(1);
			}
			this.unlockStatus = false;
			this.btn_OpenHexFile_restore = false;
			this.btn_ExportHex_restore = false;
			this.btn_ProgramVerify_restore = false;
			this.btn_ReadDevice_restore = false;
			this.btn_EraseDevice_restore = false;
			this.btn_Verify_restore = false;
			this.btn_ResetDevice_restore = false;
			this.ckbox_ConfigWordProgramming.Checked = false;
			this.ckbox_ConfigWordProgramming_restore = false;
			byte region = 0;
			do
			{
				byte* memoryRegion = this.getMemoryRegion(region);
				this.pData = memoryRegion;
				if ((IntPtr) memoryRegion != IntPtr.Zero)
				{
					free(memoryRegion);
					this.setMemoryRegion(region, NULL);
				}
				++region;
			}
			while ((uint) region < 6U);
		}

		private void btn_ResetDevice_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			this.DisableButtons();
			this.ckbox_ConfigWordProgramming.Checked = false;
			this.ckbox_ConfigWordProgramming_restore = false;
			this.unlockStatus = false;
			this.bootloaderState = (byte) 6;
			this.ResetThreadResults = (byte) 0;
			Thread resetThread = this.ResetThread;
			if (resetThread != null && resetThread.IsAlive)
				return;
			this.enablePrint = true;
			Thread thread = new Thread(new ThreadStart(this.ResetThreadStart));
			this.ResetThread = thread;
			thread.Start();
		}

		private unsafe void ResetThreadStart()
		{
			_BOOTLOADER_COMMAND bootloaderCommand;
			^(sbyte&) @bootloaderCommand = (sbyte) 0;
			__memset((_BOOTLOADER_COMMAND&) ((IntPtr) &bootloaderCommand + 1), 0, 65);
			uint num = 0;
			this.progressStatus = (byte) 0;
			void* fileW = CreateFileW((char*) ((IntPtr) HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt + 4), 1073741824U, 3U, NULL, 3U, 0U, NULL);
			HIDBootLoader.ErrorStatusWrite = (uint) Marshal.GetLastWin32Error();
			if ((int) HIDBootLoader.ErrorStatusWrite != 0)
			{
				this.ResetThreadResults = (byte) 2;
				this.progressStatus = (byte) 100;
			}
			else
			{
				^(sbyte&) @bootloaderCommand = (sbyte) 0;
				^(sbyte&) ((IntPtr) &bootloaderCommand + 1) = (sbyte) 8;
				this.progressStatus = (byte) 10;
				WriteFile(fileW, &bootloaderCommand, 65U, &num, NULL);
				this.ResetThreadResults = Marshal.GetLastWin32Error() != 0 ? (byte) 2 : (byte) 1;
				this.progressStatus = (byte) 100;
			}
		}

		private unsafe void tmr_ThreadStatus_Tick(object sender, EventArgs e)
		{
			if (this.inTimer)
				return;
			this.inTimer = true;
			if ((uint) this.progressStatus > 100U)
				this.progressStatus = (byte) 100;
			this.progressBar_Status.Value = (int) this.progressStatus;
			switch (this.bootloaderState)
			{
				case byte.MaxValue:
					this.EnableButtons();
					break;
				case 0:
					switch (this.QueryThreadResults)
					{
						case 0:
							if (this.enablePrint)
							{
								this.listBox1.Items.Add((object) "Query Running");
								this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
								this.enablePrint = false;
								break;
							}
							break;
						case 1:
							this.btn_OpenHexFile_restore = true;
							this.btn_ReadDevice_restore = true;
							this.btn_ResetDevice_restore = true;
							this.btn_EraseDevice_restore = true;
							if (this.ckbox_ConfigWordProgramming.Checked)
								this.btn_EraseDevice_restore = false;
							byte region1 = 0;
							do
							{
								byte* memoryRegion = this.getMemoryRegion(region1);
								this.pData = memoryRegion;
								if ((IntPtr) memoryRegion != IntPtr.Zero)
								{
									free(memoryRegion);
									this.setMemoryRegion(region1, NULL);
								}
								++region1;
							}
							while ((uint) region1 < 6U);
							byte region2 = 0;
							if (0U < (uint) this.memoryRegionsDetected)
							{
								do
								{
									_MEMORY_REGION* memoryRegions = Form1.memoryRegions;
									void* voidPtr = malloc((uint) (*(int*) ((int) region2 * 9 + (IntPtr) Form1.memoryRegions + 5) + 1) * (uint) this.bytesPerAddress);
									this.pData = (byte*) voidPtr;
									this.setMemoryRegion(region2, (byte*) voidPtr);
									if ((IntPtr) this.pData != IntPtr.Zero)
										++region2;
									else
										goto label_62;
								}
								while ((uint) region2 < (uint) this.memoryRegionsDetected);
								goto label_67;
label_62:
								byte region3 = 0;
								do
								{
									byte* memoryRegion = this.getMemoryRegion(region3);
									this.pData = memoryRegion;
									if ((IntPtr) memoryRegion != IntPtr.Zero)
									{
										free(memoryRegion);
										this.setMemoryRegion(region3, NULL);
									}
									++region3;
								}
								while ((uint) region3 < 6U);
								this.enablePrint = true;
								this.listBox1.Items.Add((object) "Application unable to allocate enough memory for the specified memory regions");
								this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
								this.enablePrint = false;
								this.bootloaderState = byte.MaxValue;
								this.QueryThreadResults = byte.MaxValue;
								this.inTimer = false;
								return;
							}
label_67:
							byte region4 = 0;
							if (0U < (uint) this.memoryRegionsDetected)
							{
								do
								{
									byte* memoryRegion = this.getMemoryRegion(region4);
									uint num1 = 0;
									int num2 = (int) region4 * 9;
									if (0U < (uint) *(int*) (num2 + (IntPtr) Form1.memoryRegions + 5) * (uint) this.bytesPerAddress)
									{
										do
										{
											if ((int) this.bytesPerAddress == 2 && ((int) num1 + 1 & 3) == 0)
											{
												*memoryRegion = (byte) 0;
												++memoryRegion;
											}
											else
											{
												*memoryRegion = byte.MaxValue;
												++memoryRegion;
											}
											++num1;
										}
										while (num1 < (uint) *(int*) (num2 + (IntPtr) Form1.memoryRegions + 5) * (uint) this.bytesPerAddress);
									}
									++region4;
								}
								while ((uint) region4 < (uint) this.memoryRegionsDetected);
							}
							this.bootloaderState = byte.MaxValue;
							this.QueryThreadResults = byte.MaxValue;
							break;
						case 2:
						case 3:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "Application unable to communicate with the device");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							this.bootloaderState = byte.MaxValue;
							this.QueryThreadResults = byte.MaxValue;
							break;
						default:
							this.bootloaderState = byte.MaxValue;
							this.QueryThreadResults = byte.MaxValue;
							break;
					}
				case 1:
					switch (this.ProgramThreadResults)
					{
						case 0:
							break;
						case 1:
							this.ListBoxUpdate(5);
							this.bootloaderState = byte.MaxValue;
							this.VerifyThreadResults = byte.MaxValue;
							this.progressStatus = (byte) 100;
							this.progressBar_Status.Value = 100;
							HIDBootLoader.MyDeviceAttachedStatus = 0;
							this.gbol_SuccessProgram = true;
							this.DeviceRemoved();
							break;
						case 2:
						case 3:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "Error during the Program/Verify process");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							this.bootloaderState = byte.MaxValue;
							this.ProgramThreadResults = byte.MaxValue;
							break;
						case 5:
							this.ListBoxUpdate(8);
							break;
						case 6:
							this.ListBoxUpdate(6);
							break;
						default:
							this.bootloaderState = byte.MaxValue;
							this.ProgramThreadResults = byte.MaxValue;
							break;
					}
				case 2:
					switch (this.EraseThreadResults)
					{
						case 0:
							if (this.enablePrint)
							{
								this.listBox1.Items.Add((object) "Erase running");
								this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
								this.enablePrint = false;
								break;
							}
							break;
						case 1:
							Thread queryThread1 = this.QueryThread;
							if (queryThread1 != null && queryThread1.IsAlive)
							{
								this.inTimer = false;
								return;
							}
							this.QueryThreadResults = (byte) 0;
							Thread thread1 = new Thread(new ThreadStart(this.QueryThreadStart));
							this.QueryThread = thread1;
							thread1.Start();
							this.EraseThreadResults = (byte) 6;
							break;
						case 2:
						case 5:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "Error while erasing device");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							this.bootloaderState = byte.MaxValue;
							this.EraseThreadResults = byte.MaxValue;
							break;
						case 6:
							switch (this.QueryThreadResults)
							{
								case 0:
									break;
								case 1:
									this.EraseThreadResults = (byte) 7;
									break;
								default:
									this.EraseThreadResults = (byte) 5;
									break;
							}
						case 7:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "Erase Complete");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							this.bootloaderState = byte.MaxValue;
							this.EraseThreadResults = byte.MaxValue;
							break;
						default:
							this.bootloaderState = byte.MaxValue;
							this.EraseThreadResults = byte.MaxValue;
							break;
					}
				case 3:
					switch (this.VerifyThreadResults)
					{
						case 0:
							if (this.enablePrint)
							{
								this.listBox1.Items.Add((object) "Verify Started");
								this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
								this.enablePrint = false;
							}
							this.bootloaderState = byte.MaxValue;
							this.VerifyThreadResults = byte.MaxValue;
							break;
						case 1:
							if ((int) this.ProgramThreadResults != (int) byte.MaxValue)
							{
								this.ProgramThreadResults = byte.MaxValue;
								this.enablePrint = true;
								this.listBox1.Items.Add((object) "Erase/Program/Verify Completed Successfully");
								this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
								this.enablePrint = false;
							}
							else
							{
								this.enablePrint = true;
								this.listBox1.Items.Add((object) "Verify Completed Successfully");
								this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
								this.enablePrint = false;
							}
							this.bootloaderState = byte.MaxValue;
							this.VerifyThreadResults = byte.MaxValue;
							break;
						case 2:
						case 3:
						case 4:
							if ((int) this.ProgramThreadResults != (int) byte.MaxValue)
							{
								this.ProgramThreadResults = byte.MaxValue;
								this.enablePrint = true;
								this.listBox1.Items.Add((object) "Program/Verify Failure");
								this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
								this.enablePrint = false;
							}
							else
							{
								this.enablePrint = true;
								this.listBox1.Items.Add((object) "Verify Failure");
								this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
								this.enablePrint = false;
							}
							this.bootloaderState = byte.MaxValue;
							this.VerifyThreadResults = byte.MaxValue;
							break;
						default:
							this.bootloaderState = byte.MaxValue;
							this.VerifyThreadResults = byte.MaxValue;
							break;
					}
				case 4:
					switch (this.ReadThreadResults)
					{
						case 0:
							if (this.enablePrint)
							{
								this.listBox1.Items.Add((object) "Reading Device");
								this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
								this.enablePrint = false;
								break;
							}
							break;
						case 1:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "Read Complete");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							this.bootloaderState = byte.MaxValue;
							this.ReadThreadResults = byte.MaxValue;
							this.btn_ExportHex_restore = true;
							break;
						case 2:
						case 3:
							this.bootloaderState = byte.MaxValue;
							this.ReadThreadResults = byte.MaxValue;
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "Error: Unable to complete read operation.");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							this.progressBar_Status.Value = 100;
							break;
						default:
							this.bootloaderState = byte.MaxValue;
							this.ReadThreadResults = byte.MaxValue;
							break;
					}
				case 5:
					switch (this.UnlockConfigThreadResults)
					{
						case 1:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "Configuration bits unlocked\\locked successfully");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							this.UnlockConfigThreadResults = byte.MaxValue;
							this.bootloaderState = (byte) 0;
							this.QueryThreadResults = (byte) 0;
							Thread queryThread2 = this.QueryThread;
							if (queryThread2 != null && queryThread2.IsAlive)
							{
								this.inTimer = false;
								return;
							}
							Thread thread2 = new Thread(new ThreadStart(this.QueryThreadStart));
							this.QueryThread = thread2;
							thread2.Start();
							break;
						case 2:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "Unable to unlock\\lock the configuration bits");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							this.bootloaderState = byte.MaxValue;
							this.UnlockConfigThreadResults = byte.MaxValue;
							break;
					}
				case 6:
					switch (this.ResetThreadResults)
					{
						case 1:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "Device Successfully Reset");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							this.bootloaderState = byte.MaxValue;
							this.ResetThreadResults = byte.MaxValue;
							break;
						case 2:
							this.enablePrint = true;
							this.listBox1.Items.Add((object) "Unable to reset the device");
							this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
							this.enablePrint = false;
							this.bootloaderState = byte.MaxValue;
							this.ResetThreadResults = byte.MaxValue;
							break;
					}
			}
			this.inTimer = false;
		}

		private unsafe string HexToString(uint input, byte bytes)
		{
			byte num1 = 0;
			$ArrayType$$$BY08_W arrayTypeBy08W;
			do
			{
				^(short&) ((int) num1 * 2 + (IntPtr) &arrayTypeBy08W) = (short) 48;
				++num1;
			}
			while ((uint) num1 < 9U);
			byte num2 = 0;
			int length = (int) bytes * 2;
			if (0 < length)
			{
				do
				{
					byte num3 = (byte) ((int) (byte) input & 15);
					if ((uint) num3 <= 9U)
					{
						^(short&) ((IntPtr) &arrayTypeBy08W + 14 - ((int) num2 << 1)) = (short) ((int) num3 + 48);
					}
					else
					{
						^(short&) ((IntPtr) &arrayTypeBy08W + 14 - ((int) num2 << 1)) = (short) ((int) num3 + 55);
					}
					input >>= 4;
					++num2;
				}
				while ((int) num2 < length);
			}
			^(short&) ((IntPtr) &arrayTypeBy08W + 18) = (short) 0;
			return new string((char*) &arrayTypeBy08W).Substring(4 - (int) bytes << 1, length);
		}

		private uint StringToHex(string s)
		{
			uint num1 = 0;
			uint num2 = 1;
			byte num3 = 0;
			if (0 < s.Length)
			{
				do
				{
					string str = s;
					int index = str.Length - (int) num3 - 1;
					char ch = str[index];
					num1 = ((uint) (ushort) ((uint) ch + 65471U) > 5U ? ((uint) (ushort) ((uint) ch + 65439U) > 5U ? (uint) (char) ((int) ch - 48) : (uint) (char) ((int) ch - 87)) : (uint) (char) ((int) ch - 55)) * num2 + num1;
					num2 *= 16U;
					++num3;
				}
				while ((int) num3 < s.Length);
			}
			return num1;
		}

		private void Form1_SizeChanged(object sender, EventArgs e)
		{
			this.listBox1.Width = this.Size.Width - 50;
			this.listBox1.Height = this.Size.Height - 120;
		}

		private void DisableButtons()
		{
			Form1 form1_1 = this;
			int num1 = form1_1.btn_Verify.Enabled ? 1 : 0;
			form1_1.btn_Verify_restore = num1 != 0;
			Form1 form1_2 = this;
			int num2 = form1_2.btn_ResetDevice.Enabled ? 1 : 0;
			form1_2.btn_ResetDevice_restore = num2 != 0;
			Form1 form1_3 = this;
			int num3 = form1_3.btn_ProgramVerify.Enabled ? 1 : 0;
			form1_3.btn_ProgramVerify_restore = num3 != 0;
			Form1 form1_4 = this;
			int num4 = form1_4.btn_OpenHexFile.Enabled ? 1 : 0;
			form1_4.btn_OpenHexFile_restore = num4 != 0;
			Form1 form1_5 = this;
			int num5 = form1_5.btn_ExportHex.Enabled ? 1 : 0;
			form1_5.btn_ExportHex_restore = num5 != 0;
			Form1 form1_6 = this;
			int num6 = form1_6.btn_EraseDevice.Enabled ? 1 : 0;
			form1_6.btn_EraseDevice_restore = num6 != 0;
			Form1 form1_7 = this;
			int num7 = form1_7.btn_ReadDevice.Enabled ? 1 : 0;
			form1_7.btn_ReadDevice_restore = num7 != 0;
			this.btn_Verify.Enabled = false;
			this.btn_ResetDevice.Enabled = false;
			this.btn_ProgramVerify.Enabled = false;
			this.btn_OpenHexFile.Enabled = false;
			this.button_mHex.Enabled = false;
			this.btn_ExportHex.Enabled = false;
			this.btn_EraseDevice.Enabled = false;
			this.btn_ReadDevice.Enabled = false;
			this.ckbox_ConfigWordProgramming.Enabled = false;
		}

		private void EnableButtons()
		{
			this.btn_Verify.Enabled = this.btn_Verify_restore;
			this.btn_ResetDevice.Enabled = this.btn_ResetDevice_restore;
			this.btn_ProgramVerify.Enabled = this.btn_ProgramVerify_restore;
			this.btn_OpenHexFile.Enabled = this.btn_OpenHexFile_restore;
			this.button_mHex.Enabled = this.btn_OpenHexFile.Enabled;
			this.btn_ExportHex.Enabled = this.btn_ExportHex_restore;
			this.btn_EraseDevice.Enabled = this.btn_EraseDevice_restore;
			this.btn_ReadDevice.Enabled = this.btn_ReadDevice_restore;
			this.ckbox_ConfigWordProgramming.Enabled = this.ckbox_ConfigWordProgramming_restore;
		}

		private unsafe byte* getMemoryRegion(byte region)
		{
			switch (region)
			{
				case 0:
					return this.pData0;
				case 1:
					return this.pData1;
				case 2:
					return this.pData2;
				case 3:
					return this.pData3;
				case 4:
					return this.pData4;
				case 5:
					return this.pData5;
				default:
					return NULL;
			}
		}

		private unsafe void setMemoryRegion(byte region, byte* p)
		{
			switch (region)
			{
				case 0:
					this.pData0 = p;
					break;
				case 1:
					this.pData1 = p;
					break;
				case 2:
					this.pData2 = p;
					break;
				case 3:
					this.pData3 = p;
					break;
				case 4:
					this.pData4 = p;
					break;
				case 5:
					this.pData5 = p;
					break;
			}
		}

		private void btn_Query_Click(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
		}

		private void btn_ClearListbox_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		private void comboBox_Language_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.InitializeLanguage();
		}

		private unsafe void button_mHex_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "bin files (*.bin)|*.bin";
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() != DialogResult.OK)
				return;
			this.Load_mHexFile((sbyte*) Marshal.StringToHGlobalAnsi(openFileDialog.FileName));
			if (HIDBootLoader.g_first_time == 1)
				this.LoadTmpHexToMem();
			else
				remove((sbyte*) &??_C@_0BA@BJPDJJDH@c?3?2Temp?2tmp?4tmp?$AA@);
			HIDBootLoader.g_first_time = 1;
		}

		private unsafe void LoadTmpHexToMem()
		{
			FileStream fileStream = null;
			StreamReader streamReader = null;
			Stream stream = null;
			int num1 = (int) __untypedstackalloc(___CxxQueryExceptionSize());
			string path = "c:\\Temp\\tmp.tmp";
			uint num2 = 0;
			this.DisableButtons();
			uint exceptionCode;
			uint num3;

			bool flag1 = false;
			try
			{
				fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
				streamReader = new StreamReader(fileStream);
			}
			catch
			{
				if (fileStream != null)
				{
					fileStream.Close();
					fileStream.Dispose();
				}
				if (stream == null)
					return;
				stream.Close();
				stream.Dispose();
				return;
			}
			bool flag2 = false;
label_36:
			uint hex1;
			string s;
			uint num5;
			byte num6;
			byte num7;
			do
			{
				do
				{
					string str1;
					do
					{
						string str2 = streamReader.ReadLine();
						if (str2 != null && !flag2)
							str1 = str2.Trim();
						else
							goto label_92;
					}
					while (str1.Length <= 0);
					if ((int) str1[0] != 58)
						flag1 = true;
					else
						str1 = str1.Substring(1, str1.Length - 1);
					hex1 = this.StringToHex(str1.Substring(0, 2));
					str1.Substring(2, 4);
					uint hex2 = this.StringToHex(str1.Substring(2, 4));
					uint hex3 = this.StringToHex(str1.Substring(6, 2));
					s = str1.Substring(8, (int) hex1 << 1);
					uint hex4 = this.StringToHex(str1.Substring((int) hex1 + 4 << 1, 2));
					uint num4 = 0;
					byte num8 = 0;
					if (0U < hex1 + 4U)
					{
						do
						{
							num4 = this.StringToHex(str1.Substring((int) num8 << 1, 2)) + num4;
							++num8;
						}
						while ((uint) num8 < hex1 + 4U);
					}
					if ((~(int) num4 + 1 & (int) byte.MaxValue) != (int) hex4)
					{
						this.enablePrint = true;
						this.listBox1.Items.Add((object) "ERROR: There is a checksum error in the hex file.");
						this.listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
						this.enablePrint = false;
						goto label_59;
					}
					else if (!flag1)
					{
						if ((int) hex3 != 0)
						{
							if ((int) hex3 != 1)
							{
								if ((int) hex3 == 4)
									num2 = this.StringToHex(s);
							}
							else
								flag2 = true;
						}
						else
						{
							num5 = num2 * 65536U + hex2;
							num6 = (byte) 0;
						}
					}
					else
						goto label_59;
				}
				while (0U >= (uint) this.memoryRegionsDetected);
				do
				{
					Form1 form1 = this;
					int num4 = (int) num6;
					byte* memoryRegion = form1.getMemoryRegion((byte) num4);
					form1.pData = memoryRegion;
					int num8 = (int) num6 * 9;
					if (num5 >= (uint) *(int*) (num8 + (IntPtr) Form1.memoryRegions + 1) * (uint) this.bytesPerAddress)
					{
						_MEMORY_REGION* memoryRegionPtr = (_MEMORY_REGION*) (num8 + (IntPtr) Form1.memoryRegions + 5);
						if (num5 < (uint) (*(int*) (num8 + (IntPtr) Form1.memoryRegions + 1) + *(int*) memoryRegionPtr) * (uint) this.bytesPerAddress)
							goto label_55;
					}
					++num6;
				}
				while ((uint) num6 < (uint) this.memoryRegionsDetected);
				continue;
label_55:
				num7 = (byte) 0;
			}
			while (0U >= hex1);
			int num9 = (int) num6 * 9;
			do
			{
				_MEMORY_REGION* memoryRegions = Form1.memoryRegions;
				uint hex2 = this.StringToHex(s.Substring((int) num7 << 1, 2));
				byte* numPtr1 = (byte*) ((int) num7 - *(int*) (num9 + (IntPtr) Form1.memoryRegions + 1) * (int) this.bytesPerAddress + (IntPtr) this.pData + (int) num5);
				byte* numPtr2 = (byte*) ((*(int*) (num9 + (IntPtr) Form1.memoryRegions + 5) + 1) * (int) this.bytesPerAddress + (IntPtr) this.pData);
				if (numPtr1 < numPtr2)
				{
					*numPtr1 = (byte) hex2;
					++num7;
				}
				else
					break;
			}
			while ((uint) num7 < hex1);
			goto label_36;
label_59:
			if (fileStream != null)
			{
				fileStream.Close();
				fileStream.Dispose();
			}

			if (streamReader != null)
			{
				streamReader.Close();
				streamReader.Dispose();
			}

			if (stream == null)
				return;
			stream.Close();
			stream.Dispose();
			return;

label_92:
			if (!flag1)
			{
				this.gbol_SuccessProgram = false;
				this.ListBoxUpdate(4);
			}
			this.btn_ProgramVerify_restore = true;
			if (!this.ckbox_ConfigWordProgramming.Checked)
				this.btn_EraseDevice_restore = true;
			this.btn_ExportHex_restore = true;
			this.btn_Verify_restore = true;

			if (fileStream != null)
			{
				fileStream.Close();
				fileStream.Dispose();
			}

			if (streamReader != null)
			{
				streamReader.Close();
				streamReader.Dispose();
			}

			if (stream != null)
			{
				stream.Close();
				stream.Dispose();
			}
label_132:
			remove("C:\\Temp\\tmp.tmp");
		}

		private void comboBox_Firmware_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.UpdateFirmwareDescriptor();
			this.LoadTmpHexToMem();
		}

		[HandleProcessCorruptedStateExceptions]
		protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool _param1)
		{
			if (param0)
			{
				try
				{
					this.~Form1();
				}
				finally
				{
					base.Dispose(true);
				}
			}
			else
				base.Dispose(false);
		}
	}
}
