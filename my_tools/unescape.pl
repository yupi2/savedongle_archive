use File::Slurp;

my $content = read_file($ARGV[0]);
$content =~ s/\\u([[:xdigit:]]{4})/chr(eval("0x$1"))/egis;
write_file($ARGV[1], $content);
