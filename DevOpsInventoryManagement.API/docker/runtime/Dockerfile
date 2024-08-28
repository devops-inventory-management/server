FROM devopsinventorymanagementapi:latest AS build-env

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/DevOpsInventoryManagement.API/out .