# Build Image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /source

## Copy sources
COPY . /source

## Build
RUN dotnet restore --use-current-runtime
RUN dotnet publish -c Release -o /app --use-current-runtime --self-contained false --no-restore
RUN ls -al -R /app

# Final Image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app

## Copy compiled files
COPY --from=build /app /app

## Set entrypoint
ENTRYPOINT ["/app/ProjectManagementCMS_Blazor"]
