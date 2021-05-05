# EPPlus: repro for weird `AutoFitColumns` behavior

execute [run.ps1](run.ps1)

1. build and run "normal"
   > As expected: 25.290019989013672
1. build and run with defined `WINDOW` to new up a System.Windows.Window
   > Creating window...  
   > Unhandled exception. System.Exception: Unexpected difference 25.29 <> 37.57788848876953  
   > at EPP.Test.Program.Main(String[] args) in C:\Users\rschw\Documents\Projects\EPP.Test\EPP.Test\Program.cs:line 29