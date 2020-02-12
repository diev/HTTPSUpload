@echo off
rem .NET 4.7.2+
set csc=%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\csc.exe
if exist %csc% goto compile

rem Windows 7+
rem set csc=%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\csc.exe
rem if exist %csc% goto compile

rem Windows 2003
rem set csc=%SystemRoot%\Microsoft.NET\Framework\v3.5\csc.exe
rem if exist %csc% goto compile

rem Windows XP
rem set csc=%SystemRoot%\Microsoft.NET\Framework\v2.0.50727\csc.exe
rem if exist %csc% goto compile

echo No Microsoft .NET ?!!
goto :eof

:compile
%csc% /out:HTTPSUpload.exe /recurse:*.cs
goto :eof
