TaskKill /F /IM dotnet.exe
iisreset /stop
cd C:\TC\MyProjects\ProofOfConcept\ProofOfConcept
dotnet publish --framework netcoreapp2.1 --output "c:\PUBLISHED\ProofOfConcept" --configuration Debug
iisreset /start
pause  