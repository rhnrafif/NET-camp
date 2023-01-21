#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RESTAPIEnigma/RESTAPIEnigma.csproj", "RESTAPIEnigma/"]
RUN dotnet restore "RESTAPIEnigma/RESTAPIEnigma.csproj"
COPY . .
WORKDIR "/src/RESTAPIEnigma"
RUN dotnet build "RESTAPIEnigma.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RESTAPIEnigma.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RESTAPIEnigma.dll"]