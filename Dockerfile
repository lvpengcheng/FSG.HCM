#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["services/host/FSG.HCM.HttpApi.Host/FSG.HCM.HttpApi.Host.csproj", "services/host/FSG.HCM.HttpApi.Host/"]
COPY ["frameworks/src/FSG.HCM.CAP.EntityFrameworkCore/FSG.HCM.CAP.EntityFrameworkCore.csproj", "frameworks/src/FSG.HCM.CAP.EntityFrameworkCore/"]
COPY ["frameworks/src/FSG.HCM.CAP/FSG.HCM.CAP.csproj", "frameworks/src/FSG.HCM.CAP/"]
COPY ["frameworks/src/FSG.HCM.Localization/FSG.HCM.Localization.csproj", "frameworks/src/FSG.HCM.Localization/"]
COPY ["modules/FlowManagement/src/FSG.HCM.FlowManagement/FSG.HCM.FlowManagement.csproj", "modules/FlowManagement/src/FSG.HCM.FlowManagement/"]
COPY ["frameworks/src/FSG.HCM.Core/FSG.HCM.Core.csproj", "frameworks/src/FSG.HCM.Core/"]
COPY ["modules/Onboarding/src/FSG.HCM.Onboarding/FSG.HCM.Onboarding.csproj", "modules/Onboarding/src/FSG.HCM.Onboarding/"]
COPY ["shared/FSG.HCM.Shared.Hosting.Microservices/FSG.HCM.Shared.Hosting.Microservices.csproj", "shared/FSG.HCM.Shared.Hosting.Microservices/"]
COPY ["services/src/FSG.HCM.Application/FSG.HCM.Application.csproj", "services/src/FSG.HCM.Application/"]
COPY ["modules/BasicManagement/src/FSG.HCM.BasicManagement.Application/FSG.HCM.BasicManagement.Application.csproj", "modules/BasicManagement/src/FSG.HCM.BasicManagement.Application/"]
COPY ["modules/BasicManagement/src/FSG.HCM.BasicManagement.Application.Contracts/FSG.HCM.BasicManagement.Application.Contracts.csproj", "modules/BasicManagement/src/FSG.HCM.BasicManagement.Application.Contracts/"]
COPY ["modules/BasicManagement/src/FSG.HCM.BasicManagement.Domain.Shared/FSG.HCM.BasicManagement.Domain.Shared.csproj", "modules/BasicManagement/src/FSG.HCM.BasicManagement.Domain.Shared/"]
COPY ["modules/BasicManagement/src/FSG.HCM.BasicManagement.Domain/FSG.HCM.BasicManagement.Domain.csproj", "modules/BasicManagement/src/FSG.HCM.BasicManagement.Domain/"]
COPY ["modules/DataDictionaryManagement/src/FSG.HCM.DataDictionaryManagement.Application/FSG.HCM.DataDictionaryManagement.Application.csproj", "modules/DataDictionaryManagement/src/FSG.HCM.DataDictionaryManagement.Application/"]
COPY ["modules/DataDictionaryManagement/src/FSG.HCM.DataDictionaryManagement.Application.Contracts/FSG.HCM.DataDictionaryManagement.Application.Contracts.csproj", "modules/DataDictionaryManagement/src/FSG.HCM.DataDictionaryManagement.Application.Contracts/"]
COPY ["modules/DataDictionaryManagement/src/FSG.HCM.DataDictionaryManagement.Domain.Shared/FSG.HCM.DataDictionaryManagement.Domain.Shared.csproj", "modules/DataDictionaryManagement/src/FSG.HCM.DataDictionaryManagement.Domain.Shared/"]
COPY ["modules/DataDictionaryManagement/src/FSG.HCM.DataDictionaryManagement.Domain/FSG.HCM.DataDictionaryManagement.Domain.csproj", "modules/DataDictionaryManagement/src/FSG.HCM.DataDictionaryManagement.Domain/"]
COPY ["modules/NotificationManagement/src/FSG.HCM.NotificationManagement.Application/FSG.HCM.NotificationManagement.Application.csproj", "modules/NotificationManagement/src/FSG.HCM.NotificationManagement.Application/"]
COPY ["modules/NotificationManagement/src/FSG.HCM.NotificationManagement.Application.Contracts/FSG.HCM.NotificationManagement.Application.Contracts.csproj", "modules/NotificationManagement/src/FSG.HCM.NotificationManagement.Application.Contracts/"]
COPY ["modules/NotificationManagement/src/FSG.HCM.NotificationManagement.Domain.Shared/FSG.HCM.NotificationManagement.Domain.Shared.csproj", "modules/NotificationManagement/src/FSG.HCM.NotificationManagement.Domain.Shared/"]
COPY ["modules/NotificationManagement/src/FSG.HCM.NotificationManagement.Domain/FSG.HCM.NotificationManagement.Domain.csproj", "modules/NotificationManagement/src/FSG.HCM.NotificationManagement.Domain/"]
COPY ["modules/LanguageManagement/src/FSG.HCM.LanguageManagement.Application/FSG.HCM.LanguageManagement.Application.csproj", "modules/LanguageManagement/src/FSG.HCM.LanguageManagement.Application/"]
COPY ["modules/LanguageManagement/src/FSG.HCM.LanguageManagement.Application.Contracts/FSG.HCM.LanguageManagement.Application.Contracts.csproj", "modules/LanguageManagement/src/FSG.HCM.LanguageManagement.Application.Contracts/"]
COPY ["modules/LanguageManagement/src/FSG.HCM.LanguageManagement.Domain.Shared/FSG.HCM.LanguageManagement.Domain.Shared.csproj", "modules/LanguageManagement/src/FSG.HCM.LanguageManagement.Domain.Shared/"]
COPY ["modules/LanguageManagement/src/FSG.HCM.LanguageManagement.Domain/FSG.HCM.LanguageManagement.Domain.csproj", "modules/LanguageManagement/src/FSG.HCM.LanguageManagement.Domain/"]
COPY ["services/src/FSG.HCM.Domain/FSG.HCM.Domain.csproj", "services/src/FSG.HCM.Domain/"]
COPY ["services/src/FSG.HCM.Domain.Shared/FSG.HCM.Domain.Shared.csproj", "services/src/FSG.HCM.Domain.Shared/"]
COPY ["services/src/FSG.HCM.Application.Contracts/FSG.HCM.Application.Contracts.csproj", "services/src/FSG.HCM.Application.Contracts/"]
COPY ["services/src/FSG.HCM.FreeSqlRepository/FSG.HCM.FreeSqlRepository.csproj", "services/src/FSG.HCM.FreeSqlRepository/"]
COPY ["services/src/FSG.HCM.EntityFrameworkCore/FSG.HCM.EntityFrameworkCore.csproj", "services/src/FSG.HCM.EntityFrameworkCore/"]
COPY ["modules/BasicManagement/src/FSG.HCM.BasicManagement.EntityFrameworkCore/FSG.HCM.BasicManagement.EntityFrameworkCore.csproj", "modules/BasicManagement/src/FSG.HCM.BasicManagement.EntityFrameworkCore/"]
COPY ["modules/DataDictionaryManagement/src/FSG.HCM.DataDictionaryManagement.EntityFrameworkCore/FSG.HCM.DataDictionaryManagement.EntityFrameworkCore.csproj", "modules/DataDictionaryManagement/src/FSG.HCM.DataDictionaryManagement.EntityFrameworkCore/"]
COPY ["modules/NotificationManagement/src/FSG.HCM.NotificationManagement.EntityFrameworkCore/FSG.HCM.NotificationManagement.EntityFrameworkCore.csproj", "modules/NotificationManagement/src/FSG.HCM.NotificationManagement.EntityFrameworkCore/"]
COPY ["modules/LanguageManagement/src/FSG.HCM.LanguageManagement.EntityFrameworkCore/FSG.HCM.LanguageManagement.EntityFrameworkCore.csproj", "modules/LanguageManagement/src/FSG.HCM.LanguageManagement.EntityFrameworkCore/"]
COPY ["services/src/FSG.HCM.HttpApi/FSG.HCM.HttpApi.csproj", "services/src/FSG.HCM.HttpApi/"]
COPY ["modules/BasicManagement/src/FSG.HCM.BasicManagement.HttpApi/FSG.HCM.BasicManagement.HttpApi.csproj", "modules/BasicManagement/src/FSG.HCM.BasicManagement.HttpApi/"]
COPY ["modules/DataDictionaryManagement/src/FSG.HCM.DataDictionaryManagement.HttpApi/FSG.HCM.DataDictionaryManagement.HttpApi.csproj", "modules/DataDictionaryManagement/src/FSG.HCM.DataDictionaryManagement.HttpApi/"]
COPY ["modules/NotificationManagement/src/FSG.HCM.NotificationManagement.HttpApi/FSG.HCM.NotificationManagement.HttpApi.csproj", "modules/NotificationManagement/src/FSG.HCM.NotificationManagement.HttpApi/"]
COPY ["modules/LanguageManagement/src/FSG.HCM.LanguageManagement.HttpApi/FSG.HCM.LanguageManagement.HttpApi.csproj", "modules/LanguageManagement/src/FSG.HCM.LanguageManagement.HttpApi/"]
RUN dotnet restore "services/host/FSG.HCM.HttpApi.Host/FSG.HCM.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/services/host/FSG.HCM.HttpApi.Host"
RUN dotnet build "FSG.HCM.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FSG.HCM.HttpApi.Host.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FSG.HCM.HttpApi.Host.dll"]