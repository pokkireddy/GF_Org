FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["crudwebapp/crudwebapp.csproj", "crudwebapp/"]
RUN dotnet restore "crudwebapp/crudwebapp.csproj"
COPY . .
WORKDIR "/src/crudwebapp"
RUN dotnet build "crudwebapp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "crudwebapp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "crudwebapp.dll"]