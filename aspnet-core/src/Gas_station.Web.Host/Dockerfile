FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Gas_station.Web.Host/Gas_station.Web.Host.csproj", "src/Gas_station.Web.Host/"]
COPY ["src/Gas_station.Web.Core/Gas_station.Web.Core.csproj", "src/Gas_station.Web.Core/"]
COPY ["src/Gas_station.Application/Gas_station.Application.csproj", "src/Gas_station.Application/"]
COPY ["src/Gas_station.Core/Gas_station.Core.csproj", "src/Gas_station.Core/"]
COPY ["src/Gas_station.EntityFrameworkCore/Gas_station.EntityFrameworkCore.csproj", "src/Gas_station.EntityFrameworkCore/"]
WORKDIR "/src/src/Gas_station.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Gas_station.Web.Host", "src/Gas_station.Web.Host"]
COPY ["src/Gas_station.Web.Core", "src/Gas_station.Web.Core"]
COPY ["src/Gas_station.Application", "src/Gas_station.Application"]
COPY ["src/Gas_station.Core", "src/Gas_station.Core"]
COPY ["src/Gas_station.EntityFrameworkCore", "src/Gas_station.EntityFrameworkCore"]
WORKDIR "/src/src/Gas_station.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Gas_station.Web.Host.dll"]
