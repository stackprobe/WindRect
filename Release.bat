C:\Factory\Tools\RDMD.exe /RC out

COPY /B WindRect\WindRect\bin\Release\WindRect.exe out
COPY /B Readme_man.txt out\Readme.txt

C:\Factory\SubTools\zip.exe /O out WindRect

IF NOT "%1" == "/-P" PAUSE
