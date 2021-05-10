::@%1 cmd /k %0 :
rem @::make_proto.bat
echo off

set UnityProtolDir=..\..\..\..\Assets\BundleResources\Lua\ClientLua\Net\Protol
set LuaProtoTmpDir=.\__tmp
set LuaProtoSrcDir=..\ProtoToCS\ProtoGen\proto
set LuaPluginDir=.\plugin
SET _PROTO_PATH=F:\Work\0830\protocol

cd  %~dp0

if exist "%UnityProtolDir%" rd /s /q "%UnityProtolDir%"
md "%UnityProtolDir%"

if exist "%LuaProtoTmpDir%" rd /s /q "%LuaProtoTmpDir%"
md "%LuaProtoTmpDir%"

rem for /r "%_PROTO_PATH%" %%i in (*.proto) do (
rem 	copy /y "%%i" "%LuaProtoTmpDir%\%%~nxi"
rem )  

copy %_PROTO_PATH%\*.proto "%LuaProtoTmpDir%"

pause

DEl %LuaProtoTmpDir%\GmToolCommand.proto 

PowerShell -Command "& {$MyPath = '%LuaProtoTmpDir%';Get-ChildItem $MyPath\* -Include *.proto | Foreach-Object {[System.IO.File]::WriteAllText($_.FullName,[System.IO.File]::ReadAllText($_.FullName));}}"

cd "%LuaProtoTmpDir%"
call :stringlenth "%cd%" num 
setlocal enabledelayedexpansion
for /r %%i in (*.proto) do (   
	set absolute=%%i
	set relative=.!absolute:~%num%!
	echo !relative!
	"..\protoc.exe" --plugin=protoc-gen-lua="..\plugin\build.bat" --lua_out="..\%UnityProtolDir%" "!relative!" 
)  

cd ..
if exist "%LuaProtoTmpDir%" rd /s /q "%LuaProtoTmpDir%"

rem cd "%LuaPluginDir%"
rem @python msgid-gen-lua

echo DONE

pause
exit

:StringLenth 
	set theString=%~1
	if not defined theString goto :eof 
	set Return=0 
:StringLenth_continue 
	set /a Return+=1
	set theString=%theString:~,-1%
	if defined theString goto StringLenth_continue 
	if not "%2"=="" set %2=%Return%
goto :eof