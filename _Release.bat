C:\Factory\Tools\RDMD.exe /RC out

COPY /B WindRect\WindRect\bin\Release\WindRect.exe out
COPY /B Readme.txt out

C:\Factory\SubTools\zip.exe /O out WindRect

PAUSE
