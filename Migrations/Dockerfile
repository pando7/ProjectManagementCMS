# Build Image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /source

## Copy sources
COPY . /source

## Install EF tools
RUN dotnet tool install --global dotnet-ef

ENTRYPOINT ["bash -c 'sleep 30 && /root/.dotnet/tools/dotnet-df database update'"]
