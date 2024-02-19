FROM mcr.microsoft.com/dotnet/sdk:8.0

WORKDIR /var/temp

COPY ./E2E_Testing /var/temp/E2E_Testing
COPY ./Lift-Pass-Pricing.sln /var/temp/



RUN dotnet restore E2E_Testing/E2E_Testing.csproj
#RUN dotnet restore LiftPassPricingTests/LiftPassPricingTests.csproj

CMD ["dotnet", "test", "E2E_Testing"]
