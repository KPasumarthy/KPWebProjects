# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
# For more information, please see https://aka.ms/containercompat

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/runtime:3.1 AS base
WORKDIR /app

## Stage 1: Build the application
# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["KPConsole/KPConsole.csproj", "KPConsole/"]
RUN dotnet restore "./KPConsole/KPConsole.csproj"
COPY . .
WORKDIR "/src/KPConsole"
RUN dotnet build "./KPConsole.csproj" -c %BUILD_CONFIGURATION% -o /app/build


## Stage 2: Publish the application build
# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./KPConsole.csproj" -c %BUILD_CONFIGURATION% -o /app/publish /p:UseAppHost=false

## Stage 3: Publish the application build abd a final release
# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KPConsole.dll"]
