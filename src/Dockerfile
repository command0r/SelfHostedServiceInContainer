# See https://aka.ms/containerimagehelp for information on how to use Windows Server 1709 containers with Service Fabric.
# FROM microsoft/dotnet-framework:4.7.1-windowsservercore-1709
FROM microsoft/dotnet-framework:4.7.1-windowsservercore-ltsc2016
ARG source
WORKDIR /app
COPY ${source:-obj/Docker/publish} .
ENTRYPOINT ["C:\\app\\AspNetSelfHostService.exe"]
