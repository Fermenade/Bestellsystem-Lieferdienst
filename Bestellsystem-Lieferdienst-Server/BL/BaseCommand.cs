using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Bestellsystem_Lieferdienst_Server.BL;

public static class CommandManager
{
    private static readonly List<ICommand> Commands = new();
    static CommandManager()
    {
        RegisterAllCommandsAndSubcommands();
    }

    private static void RegisterAllCommandsAndSubcommands() //TODO: move this stuff to the right place
    {
        // Get all types in the assembly that implement ICommand
        IEnumerable<Type> commandTypes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(BaseCommand).IsAssignableFrom(t) && !t.IsAbstract);

        foreach (Type commandType in commandTypes)
        {
            // Create an instance of the command and register it
            BaseCommand commandInstance = (BaseCommand)Activator.CreateInstance(commandType);
            CommandManager.RegisterCommand(commandInstance);
            
            RegisterAllSubcommands(commandInstance);
        }
    }
    private static void RegisterCommand(ICommand command)
    {
        if (GetBaseCommand(command.Name) == null)throw new Exception("Command with same name already exists");
        Commands.Add(command);
    }
    /// <summary>
    /// Registers all Subcommands of a given BaseCommand
    /// </summary>
    /// <param name="baseCommand"></param>
    private static void RegisterAllSubcommands(BaseCommand baseCommand)
    {
        //Get all Subcommands in the assembly that implement ICommand
        IEnumerable<Type> subCommands = baseCommand.GetType().GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic)
            .Where(t =>
                typeof(ICommand).IsAssignableFrom(t) && !t.IsAbstract && 
                !typeof(BaseCommand).IsAssignableFrom(t)
            );
        
        foreach (Type commandType in subCommands)
        {
            // Create an instance of the command and register it
            ICommand commandInstance = (ICommand)Activator.CreateInstance(commandType);
            baseCommand.AddSubCommand(commandInstance);
        }
    }
    public static ICommand? GetBaseCommand(string commandName)
    {
        return Commands.FirstOrDefault(cmd =>
            cmd.Name.Equals(commandName, StringComparison.OrdinalIgnoreCase));
    }
    
    public static void ExecuteCommand(UserCommand message)
    {
        message.Command?.Execute(message.Arguments);
    }

}

public interface ICommand
{
    string Name { get; }
    bool? TakesParameter { get; }
    void Execute(string? command);
}

public abstract class BaseCommand : ICommand
{
    public abstract string Name { get; }
    public bool? TakesParameter => null;//TODO: es kann sein dass wenn diese wert nicht false ist, dann macht es etwas falsches um Usage anzeige.

    //public abstract void Execute(string[] args);
    public List<ICommand> SubCommands { get; } = new List<ICommand>();
    
    public void AddSubCommand(ICommand command)
    {
        if (GetSubCommand(command.Name) != null) throw new("Subcommand with same name already exists");
        SubCommands.Add(command);
    }

    public ICommand? GetSubCommand(string name)
    {
        return SubCommands.FirstOrDefault(cmd => cmd.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
    public void Execute(UserCommand.CArgument[] userCommand)
    {
        if (userCommand.Length == 0)
        {
            throw new ArgumentException("Command must have at least one argument");
            return;
        }
        foreach (var VARIABLE in userCommand)
        {
            VARIABLE.Command.Execute(VARIABLE.Argument);
        }
        //,   Console.WriteLine($"Executing {Name} with args: {string.Join(", ", args)}");
    }

    public void Execute(string command)//This has to be empty 
    { }
}