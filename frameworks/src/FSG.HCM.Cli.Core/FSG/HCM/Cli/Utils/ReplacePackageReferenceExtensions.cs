namespace FSG.HCM.Cli.Utils;

public static class ReplacePackageReferenceExtensions
{
    public static string ReplacePackageReferenceCore(this string content)
    {
        return content
                .Replace("<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\frameworks\\src\\FSG.HCM.Core\\FSG.HCM.Core.csproj\"/>",
                    "<PackageReference Include=\"FSG.HCM.Core\"/>")
                .Replace("<ProjectReference Include=\"..\\..\\..\\..\\aspnet-core\\frameworks\\src\\FSG.HCM.Core\\FSG.HCM.Core.csproj\"/>",
                    "<PackageReference Include=\"FSG.HCM.Core\"/>")
                .Replace("<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\shared\\FSG.HCM.Shared.Hosting.Microservices\\FSG.HCM.Shared.Hosting.Microservices.csproj\"/>",
                    "<PackageReference Include=\"FSG.HCM.Shared.Hosting.Microservices\"/>")
                .Replace("<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\shared\\FSG.HCM.Shared.Hosting.Gateways\\FSG.HCM.Shared.Hosting.Gateways.csproj\"/>",
                    "<PackageReference Include=\"FSG.HCM.Shared.Hosting.Gateways\"/>")
            ;
    }

    public static string ReplacePackageReferenceBasicManagement(this string content)
    {
        return content
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\src\\FSG.HCM.BasicManagement.Application\\FSG.HCM.BasicManagement.Application.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.BasicManagement.Application\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\src\\FSG.HCM.BasicManagement.Application.Contracts\\FSG.HCM.BasicManagement.Application.Contracts.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.BasicManagement.Application.Contracts\"/>")
            .Replace("<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\src\\FSG.HCM.BasicManagement.Domain\\FSG.HCM.BasicManagement.Domain.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.BasicManagement.Domain\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\src\\FSG.HCM.BasicManagement.Domain.Shared\\FSG.HCM.BasicManagement.Domain.Shared.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.BasicManagement.Domain.Shared\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\src\\FSG.HCM.BasicManagement.EntityFrameworkCore\\FSG.HCM.BasicManagement.EntityFrameworkCore.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.BasicManagement.EntityFrameworkCore\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\src\\FSG.HCM.BasicManagement.FreeSqlRepository\\FSG.HCM.BasicManagement.FreeSqlRepository.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.FreeSqlRepository\"/>")
            .Replace("<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\src\\FSG.HCM.BasicManagement.HttpApi\\FSG.HCM.BasicManagement.HttpApi.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.BasicManagement.HttpApi\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\src\\FSG.HCM.BasicManagement.HttpApi.Client\\FSG.HCM.BasicManagement.HttpApi.Client.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.BasicManagement.HttpApi.Client\"/>");
    }

    public static string ReplacePackageReferenceDataDictionaryManagement(this string content)
    {
        return content
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\DataDictionaryManagement\\src\\FSG.HCM.DataDictionaryManagement.Application\\FSG.HCM.DataDictionaryManagement.Application.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.DataDictionaryManagement.Application\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\DataDictionaryManagement\\src\\FSG.HCM.DataDictionaryManagement.Application.Contracts\\FSG.HCM.DataDictionaryManagement.Application.Contracts.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.DataDictionaryManagement.Application.Contracts\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\DataDictionaryManagement\\src\\FSG.HCM.DataDictionaryManagement.Domain\\FSG.HCM.DataDictionaryManagement.Domain.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.DataDictionaryManagement.Domain\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\DataDictionaryManagement\\src\\FSG.HCM.DataDictionaryManagement.Domain.Shared\\FSG.HCM.DataDictionaryManagement.Domain.Shared.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.DataDictionaryManagement.Domain.Shared\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\DataDictionaryManagement\\src\\FSG.HCM.DataDictionaryManagement.EntityFrameworkCore\\FSG.HCM.DataDictionaryManagement.EntityFrameworkCore.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.DataDictionaryManagement.EntityFrameworkCore\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\DataDictionaryManagement\\src\\FSG.HCM.DataDictionaryManagement.FreeSqlRepository\\FSG.HCM.DataDictionaryManagement.FreeSqlRepository.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.FreeSqlRepository\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\DataDictionaryManagement\\src\\FSG.HCM.DataDictionaryManagement.HttpApi\\FSG.HCM.DataDictionaryManagement.HttpApi.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.DataDictionaryManagement.HttpApi\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\DataDictionaryManagement\\src\\FSG.HCM.DataDictionaryManagement.HttpApi.Client\\FSG.HCM.DataDictionaryManagement.HttpApi.Client.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.DataDictionaryManagement.HttpApi.Client\"/>");
    }

    public static string ReplacePackageReferenceFileManagement(this string content)
    {
        return content
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\FileManagement\\src\\FSG.HCM.FileManagement.Application\\FSG.HCM.FileManagement.Application.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.FileManagement.Application\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\FileManagement\\src\\FSG.HCM.FileManagement.Application.Contracts\\FSG.HCM.FileManagement.Application.Contracts.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.FileManagement.Application.Contracts\"/>")
            .Replace("<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\FileManagement\\src\\FSG.HCM.FileManagement.Domain\\FSG.HCM.FileManagement.Domain.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.FileManagement.Domain\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\FileManagement\\src\\FSG.HCM.FileManagement.Domain.Shared\\FSG.HCM.FileManagement.Domain.Shared.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.FileManagement.Domain.Shared\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\FileManagement\\src\\FSG.HCM.FileManagement.EntityFrameworkCore\\FSG.HCM.FileManagement.EntityFrameworkCore.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.FileManagement.EntityFrameworkCore\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\FileManagement\\src\\FSG.HCM.FileManagement.FreeSqlRepository\\FSG.HCM.FileManagement.FreeSqlRepository.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.FreeSqlRepository\"/>")
            .Replace("<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\FileManagement\\src\\FSG.HCM.FileManagement.HttpApi\\FSG.HCM.FileManagement.HttpApi.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.FileManagement.HttpApi\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\FileManagement\\src\\FSG.HCM.FileManagement.HttpApi.Client\\FSG.HCM.FileManagement.HttpApi.Client.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.FileManagement.HttpApi.Client\"/>");
    }

    public static string ReplacePackageReferenceLanguageManagement(this string content)
    {
        return content
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\LanguageManagement\\src\\FSG.HCM.LanguageManagement.Application\\FSG.HCM.LanguageManagement.Application.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.LanguageManagement.Application\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\LanguageManagement\\src\\FSG.HCM.LanguageManagement.Application.Contracts\\FSG.HCM.LanguageManagement.Application.Contracts.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.LanguageManagement.Application.Contracts\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\LanguageManagement\\src\\FSG.HCM.LanguageManagement.Domain\\FSG.HCM.LanguageManagement.Domain.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.LanguageManagement.Domain\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\LanguageManagement\\src\\FSG.HCM.LanguageManagement.Domain.Shared\\FSG.HCM.LanguageManagement.Domain.Shared.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.LanguageManagement.Domain.Shared\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\LanguageManagement\\src\\FSG.HCM.LanguageManagement.EntityFrameworkCore\\FSG.HCM.LanguageManagement.EntityFrameworkCore.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.LanguageManagement.EntityFrameworkCore\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\LanguageManagement\\src\\FSG.HCM.LanguageManagement.FreeSqlRepository\\FSG.HCM.LanguageManagement.FreeSqlRepository.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.FreeSqlRepository\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\LanguageManagement\\src\\FSG.HCM.LanguageManagement.HttpApi\\FSG.HCM.LanguageManagement.HttpApi.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.LanguageManagement.HttpApi\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\LanguageManagement\\src\\FSG.HCM.LanguageManagement.HttpApi.Client\\FSG.HCM.LanguageManagement.HttpApi.Client.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.LanguageManagement.HttpApi.Client\"/>");
    }

    public static string ReplacePackageReferenceNotificationManagement(this string content)
    {
        return content
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\NotificationManagement\\src\\FSG.HCM.NotificationManagement.Application\\FSG.HCM.NotificationManagement.Application.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.NotificationManagement.Application\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\NotificationManagement\\src\\FSG.HCM.NotificationManagement.Application.Contracts\\FSG.HCM.NotificationManagement.Application.Contracts.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.NotificationManagement.Application.Contracts\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\NotificationManagement\\src\\FSG.HCM.NotificationManagement.Domain\\FSG.HCM.NotificationManagement.Domain.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.NotificationManagement.Domain\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\NotificationManagement\\src\\FSG.HCM.NotificationManagement.Domain.Shared\\FSG.HCM.NotificationManagement.Domain.Shared.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.NotificationManagement.Domain.Shared\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\NotificationManagement\\src\\FSG.HCM.NotificationManagement.EntityFrameworkCore\\FSG.HCM.NotificationManagement.EntityFrameworkCore.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.NotificationManagement.EntityFrameworkCore\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\NotificationManagement\\src\\FSG.HCM.NotificationManagement.FreeSqlRepository\\FSG.HCM.NotificationManagement.FreeSqlRepository.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.FreeSqlRepository\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\NotificationManagement\\src\\FSG.HCM.NotificationManagement.HttpApi\\FSG.HCM.NotificationManagement.HttpApi.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.NotificationManagement.HttpApi\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\NotificationManagement\\src\\FSG.HCM.NotificationManagement.HttpApi.Client\\FSG.HCM.NotificationManagement.HttpApi.Client.csproj\"/>",
                "<PackageReference Include=\"FSG.HCM.NotificationManagement.HttpApi.Client\"/>");
    }

    public static string ReplaceFSGPackageVersion(this string context, string version)
    {
        return context.Replace("MyVersion", version);
    }
}