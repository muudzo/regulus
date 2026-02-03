FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/Regulus.Api/Regulus.Api.csproj", "src/Regulus.Api/"]
COPY ["src/Regulus.Application/Regulus.Application.csproj", "src/Regulus.Application/"]
COPY ["src/Regulus.Domain/Regulus.Domain.csproj", "src/Regulus.Domain/"]
COPY ["src/Regulus.Infrastructure/Regulus.Infrastructure.csproj", "src/Regulus.Infrastructure/"]
RUN dotnet restore "src/Regulus.Api/Regulus.Api.csproj"
COPY . .
WORKDIR "/src/src/Regulus.Api"
RUN dotnet build "Regulus.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Regulus.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Regulus.Api.dll"]
