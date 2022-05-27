@ echo off
cd TA3
echo %cd%
timeout 1 >nul
echo "@running"
dotnet run
echo "@end"
pause >nul
