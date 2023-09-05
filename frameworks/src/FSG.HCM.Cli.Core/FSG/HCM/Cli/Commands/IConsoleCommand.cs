namespace FSG.HCM.Cli.Commands;

public interface IConsoleCommand
{
    Task ExecuteAsync(CommandLineArgs commandLineArgs);

    void GetUsageInfo();

    string GetShortDescription();
}