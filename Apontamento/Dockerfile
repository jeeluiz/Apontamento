#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Apontamento.csproj", "Apontamento/"]
RUN dotnet restore "Apontamento/Apontamento.csproj"
COPY . Apontamento/
WORKDIR "/src/Apontamento"
RUN dotnet build "Apontamento.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Apontamento.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Apontamento.dll"]