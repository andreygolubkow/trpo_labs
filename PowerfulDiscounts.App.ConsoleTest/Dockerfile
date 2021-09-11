FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["PowerfulDiscounts.App.ConsoleTest/PowerfulDiscounts.App.ConsoleTest.csproj", "PowerfulDiscounts.App.ConsoleTest/"]
RUN dotnet restore "PowerfulDiscounts.App.ConsoleTest/PowerfulDiscounts.App.ConsoleTest.csproj"
COPY . .
WORKDIR "/src/PowerfulDiscounts.App.ConsoleTest"
RUN dotnet build "PowerfulDiscounts.App.ConsoleTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PowerfulDiscounts.App.ConsoleTest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PowerfulDiscounts.App.ConsoleTest.dll"]
