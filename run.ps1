dotnet build
dotnet run -p EPP.Test --no-build
dotnet build -p:DefineConstants=WINDOW
dotnet run -p EPP.Test --no-build