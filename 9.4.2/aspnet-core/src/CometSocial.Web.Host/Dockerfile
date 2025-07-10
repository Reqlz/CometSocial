FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/CometSocial.Web.Host/CometSocial.Web.Host.csproj", "src/CometSocial.Web.Host/"]
COPY ["src/CometSocial.Web.Core/CometSocial.Web.Core.csproj", "src/CometSocial.Web.Core/"]
COPY ["src/CometSocial.Application/CometSocial.Application.csproj", "src/CometSocial.Application/"]
COPY ["src/CometSocial.Core/CometSocial.Core.csproj", "src/CometSocial.Core/"]
COPY ["src/CometSocial.EntityFrameworkCore/CometSocial.EntityFrameworkCore.csproj", "src/CometSocial.EntityFrameworkCore/"]
WORKDIR "/src/src/CometSocial.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/CometSocial.Web.Host", "src/CometSocial.Web.Host"]
COPY ["src/CometSocial.Web.Core", "src/CometSocial.Web.Core"]
COPY ["src/CometSocial.Application", "src/CometSocial.Application"]
COPY ["src/CometSocial.Core", "src/CometSocial.Core"]
COPY ["src/CometSocial.EntityFrameworkCore", "src/CometSocial.EntityFrameworkCore"]
WORKDIR "/src/src/CometSocial.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "CometSocial.Web.Host.dll"]
