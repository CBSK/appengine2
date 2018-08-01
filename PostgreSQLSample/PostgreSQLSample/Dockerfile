FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY PostgreSQLSample/PostgreSQLSample.csproj PostgreSQLSample/
RUN dotnet restore PostgreSQLSample/PostgreSQLSample.csproj
COPY . .
WORKDIR /src/PostgreSQLSample
RUN dotnet build PostgreSQLSample.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish PostgreSQLSample.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "PostgreSQLSample.dll"]
