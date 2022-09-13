# Build Image
FROM mcr.microsoft.com/dotnet/sdk:7.0
WORKDIR /source

## Copy sources
COPY . /source

## Install EF tools
RUN dotnet tool install --global dotnet-ef

RUN echo '\
#!/bin/sh\n\
echo "Sleeping 10s before attempting DB migration ..."\n\
sleep 10\n\
\n\
echo "Attempting DB migration ..."\n\
/root/.dotnet/tools/dotnet-ef database update --verbose --project /source\n\
echo "Done! (Exit-Code: $?)"\n' > /entrypoint.sh && chmod +x /entrypoint.sh

ENTRYPOINT ["sh", "-c", "/entrypoint.sh"]
