use File::Slurp;

# used for array for array assignments that aren't using arrays:
#	^(sbyte&) ((IntPtr) &arrayTypeBy0MaE + 14) = (sbyte) 23;
#	^(sbyte&) ((IntPtr) &arrayTypeBy0MaE + 15) = (sbyte) -117;
# matches the '23' and the '-117'

my $content = read_file($ARGV[0]);

while ($content =~ /([^ ]+);/g) {
	print "$1, ";
}

print "\n";
