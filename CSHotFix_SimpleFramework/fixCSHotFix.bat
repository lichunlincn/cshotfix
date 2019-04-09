cd Assets/CSHotFixLibaray/Generated
del /a /f /q CLRGen1\*.cs
del /a /f /q CLRGen2\*.cs
del /a /f /q DelegateGen\*.cs

copy CLRGen1\CLRBindings.cs_ CLRGen1\CLRBindings.cs
copy CLRGen2\CLRBindings2.cs_ CLRGen2\CLRBindings2.cs
copy DelegateGen\LCLFieldDelegateName.cs_ DelegateGen\LCLFieldDelegateName.cs
copy DelegateGen\LCLFunctionDelegate.cs_ DelegateGen\LCLFunctionDelegate.cs
pause
