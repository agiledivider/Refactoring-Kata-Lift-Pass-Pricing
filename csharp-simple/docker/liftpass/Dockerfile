# Dockerfile

FROM mcr.microsoft.com/dotnet/sdk:3.1

WORKDIR /var/temp

ADD ./LiftPassPricing /var/temp/LiftPassPricing
COPY ./LiftPassPricingTests /var/temp/LiftPassPricingTests
COPY ./Lift-Pass-Pricing.sln /var/temp/

RUN dotnet restore LiftPassPricing/LiftPassPricing.csproj
RUN dotnet restore LiftPassPricingTests/LiftPassPricingTests.csproj
ENTRYPOINT ["dotnet", "run", "--project", "LiftPassPricing"]
