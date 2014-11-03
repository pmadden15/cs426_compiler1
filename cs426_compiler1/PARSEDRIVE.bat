echo this file will work, all others will not > outfile.txt
Bin\debug\cs426_compiler1.exe testfile.txt >> outfile.txt
echo I tried to compare x, y, and z, it will crash on line 2 >> outfile.txt
Bin\debug\cs426_compiler1.exe testfile1.txt >> outfile.txt
echo I removed main, it will crash on line 1 >> outfile.txt
Bin\debug\cs426_compiler1.exe testfile2.txt >> outfile.txt
echo I tried to declare variables inside ifs, whiles, and procedure calls.  It will crash on line 7 >> outfile.txt
Bin\debug\cs426_compiler1.exe testfile3.txt >> outfile.txt
echo I removed a semicolon on line 2, it will crash on line 2>> outfile.txt
Bin\debug\cs426_compiler1.exe testfile2.txt >> outfile.txt