FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env 
WORKDIR /CitiesBr
COPY . ./
RUN dotnet restore "../Presentation/CitiesBr.csproj"
RUN dotnet publish "../Presentation/CitiesBr.csproj" -c Release -o out
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /Project
COPY --from=build-env /CitiesBr/out .
ENTRYPOINT ["dotnet", "CitiesBr.dll"]

# FROM microsoft/dotnet:sdk AS build-env