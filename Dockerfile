#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ABE.Assignment2.API/API.csproj", "ABE.Assignment2.API/"]
COPY ["ABE.Assignment2.DomainLogic/DomainLogic.csproj", "ABE.Assignment2.DomainLogic/"]
RUN dotnet restore "ABE.Assignment2.API/API.csproj"
COPY . .
WORKDIR "/src/ABE.Assignment2.API"
RUN dotnet build "API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ABE.Assignment2.API.dll"]