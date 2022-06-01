@ echo off
cd TA2
echo %cd%
timeout 1 >nul
echo "@running"
dotnet run
echo "@end"
pause >nul
cd ..
