::@%1 cmd /k %0 :
@::make_proto.bat
@echo off

@python protoToPb.py

echo DONE

pause
exit
