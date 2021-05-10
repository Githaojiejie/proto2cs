@echo off
SET _PROJECT_PATH=C:\MDZS
SET _PROTO_PATH=C:\common\protocol
SET _NET_FRAMEWORK_PATH=C:\Windows\Microsoft.NET\Framework\v3.5\csc.exe
cd /d %_PROJECT_PATH%\GenProtoTools

md ProtoCSFile
md SerializerGenerator
del /q .\ProtoCSFile\*.*
del /q .\SerializerGenerator\*.*
del .\*.proto
del .\*.cs

if not exist ProtoFilters.txt (
	goto NO_FILTERS_FILE
)

copy %_PROTO_PATH%\*.proto

for /f "delims=" %%i in ( 'type ProtoFilters.txt' ) do protogen -i:%%i -o:%%~ni.cs 

move .\*.cs .\ProtoCSFile\

del .\*.proto

goto END_PROGRAM
:NO_FILTERS_FILE
echo not exist ProtoFilters.txt
:END_PROGRAM

pause