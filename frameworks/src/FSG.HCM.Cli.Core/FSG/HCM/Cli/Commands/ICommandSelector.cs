namespace FSG.HCM.Cli.Commands;

public interface ICommandSelector
{
    Type Select(CommandLineArgs commandLineArgs);
}