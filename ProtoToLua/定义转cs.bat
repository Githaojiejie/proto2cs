::@%1 cmd /k %0 :
@::make_proto.bat
@echo off

@python csv2cs.py

echo DONE

pause
exit
