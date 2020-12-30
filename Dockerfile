#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
#WORKDIR /src
#COPY ["Rso3.csproj", ""]
#RUN dotnet restore "./Rso3.csproj"
#COPY . .
#WORKDIR "/src/."
#RUN dotnet build "Rso3.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "Rso3.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "Rso3.dll"]

FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY /app/publish .
ENTRYPOINT ["dotnet", "Rso3.dll"]