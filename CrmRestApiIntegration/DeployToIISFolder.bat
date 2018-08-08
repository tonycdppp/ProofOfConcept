TaskKill /F /IM dotnet.exe
iisreset /stop
cd C:\DEVELOPMENT\Ticketing\AV7\Source\Api\TheFA.Ticketing.CoreApi
dotnet publish --framework netcoreapp1.1 --output "c:\PUBLISHED\CoreApi" --configuration Debug
iisreset /start
pause  