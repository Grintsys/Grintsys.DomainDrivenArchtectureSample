FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["src/Grintsys.SROverview.Web.Host.csproj", "src/Grintsys.SROverview.Web.Host/"]
RUN dotnet restore "src/Grintsys.SROverview.Web.Host.csproj"
COPY . .
WORKDIR "src/Grintsys.SROverview.Web.Host/"
RUN dotnet build "Grintsys.SROverview.Web.Host.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Grintsys.SROverview.Web.Host.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Grintsys.SROverview.Web.Host.dll"]
