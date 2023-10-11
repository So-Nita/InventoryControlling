FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["InventoryControlling/InventoryControlling.csproj", "InventoryControlling/"]
RUN dotnet restore "InventoryControlling/InventoryControlling.csproj"
COPY . .
WORKDIR "/src/InventoryControlling"
RUN dotnet build "InventoryControlling.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InventoryControlling.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InventoryControlling.dll"]
