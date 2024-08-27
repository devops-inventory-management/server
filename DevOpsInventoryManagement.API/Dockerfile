# Use the official .NET image as a build environment
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.sln ./
COPY DevOpsInventoryManagement.API/*.csproj ./DevOpsInventoryManagement.API/
COPY DevOpsInventoryManagement.BLL/*.csproj ./DevOpsInventoryManagement.BLL/
COPY DevOpsInventoryManagement.DAL/*.csproj ./DevOpsInventoryManagement.DAL/
COPY DevOpsInventoryManagement.Domain/*.csproj ./DevOpsInventoryManagement.Domain/
RUN dotnet restore

# Copy everything else and build
COPY . ./
WORKDIR /app/DevOpsInventoryManagement.API
# Install dotnet-ef tool
RUN dotnet tool install --global dotnet-ef --version 8.0.8
ENV PATH="$PATH:/root/.dotnet/tools"

RUN dotnet publish -c Release -o out /p:UseAppHost=false

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/DevOpsInventoryManagement.API/out .
ENTRYPOINT ["dotnet", "DevOpsInventoryManagement.API.dll"]
EXPOSE 80