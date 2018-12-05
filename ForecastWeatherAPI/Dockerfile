FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["ForecastWeatherAPI/ForecastWeatherAPI.csproj", "ForecastWeatherAPI/"]
RUN dotnet restore "ForecastWeatherAPI/ForecastWeatherAPI.csproj"
COPY . .
WORKDIR "/src/ForecastWeatherAPI"
RUN dotnet build "ForecastWeatherAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ForecastWeatherAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ForecastWeatherAPI.dll"]