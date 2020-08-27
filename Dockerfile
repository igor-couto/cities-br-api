FROM microsoft/dotnet:sdk AS build-env
WORKDIR /CitiesBr
# Copy everything and build
COPY . ./
RUN dotnet restore "./CitiesBr.csproj"
RUN dotnet publish "CitiesBr.csproj" -c Release -o out
FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /CitiesBr
COPY --from=build-env /CitiesBr/out .
ENTRYPOINT ["dotnet", "CitiesBr.dll"]