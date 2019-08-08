:begin
    dotnet run -c Release
    if %errorlevel% == 5 goto begin