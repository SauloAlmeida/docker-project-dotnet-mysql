FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /source
COPY . .
RUN dotnet restore "DockerDotnetMySQL.csproj" --disable-parallel
RUN dotnet publish "DockerDotnetMySQL.csproj" -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app ./

ENV ASPNETCORE_HTTP_PORT=https://+:5001 
ENV ASPNETCORE_URLS=http://+:5000 
EXPOSE 5000

ENTRYPOINT [ "dotnet", "DockerDotnetMySQL.dll"]

# docker run -p 5000:5000 -p 5001:5001 docker-dotnet-api