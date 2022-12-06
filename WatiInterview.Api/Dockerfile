#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["WatiInterview.Api/WatiInterview.Api.csproj", "WatiInterview.Api/"]
RUN dotnet restore "WatiInterview.Api/WatiInterview.Api.csproj"
COPY . .
WORKDIR "/src/WatiInterview.Api"
RUN dotnet build "WatiInterview.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WatiInterview.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WatiInterview.Api.dll"]