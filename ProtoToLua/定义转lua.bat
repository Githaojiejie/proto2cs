::@%1 cmd /k %0 :
@::make_proto.bat
@echo off

@python csv2lua.py

echo DONE

pause
exit
