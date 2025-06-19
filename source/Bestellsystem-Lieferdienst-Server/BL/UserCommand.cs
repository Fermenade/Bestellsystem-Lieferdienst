using Client_Server_Code_Library;
using System.Diagnostics.CodeAnalysis;

namespace Bestellsystem_Lieferdienst_Server.BL;

[SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
public class UserCommand
{
    public class CArgument
    {
        public User? User;
        public ICommand Command { get; private set; }
        public string? Argument { get; private set; }

        public CArgument(ICommand command)
        {
            this.Command = command;
        }

        public CArgument(ICommand command, string argument)
        {
            this.Command = command;
            this.Argument = argument;
        }

        public CArgument(User user, CArgument argument)
        {
            this.User = user;
            this.Command = argument.Command;
            this.Argument = argument.Argument;
        }
    }

    public BaseCommand Command { get; private set; }

    public CArgument? Argument { get; private set; }

    public UserCommand(User? User, string command)
    {
        if (string.IsNullOrWhiteSpace(command)) throw new Exception("Not a valid Command");
        if (command.Length == 0) throw new Exception("Not a valid Command");


        string[]
            parts = StringFormating
                .Explode(command); //TODO: das explode sorgt auch dafür, dass der prefix "-" nicht mehr als ein einzelnes element angesehen wird

        this.Command = (BaseCommand)CommandManager.GetBaseCommand(parts[0]) ?? throw new Exception("Not a valid Command");
        this.Argument = new(User, ParseArgument(parts.Skip(1).ToArray()));
    }

    CArgument? ParseArgument(string[] input)
    {
        if (input.Length > 2)
        {
            throw new Exception("Commands max take 1 Argument");
        }
        string arg = input.Length == 0 ? "" : StringFormating.RemoveQuotes(input[0]);

        ICommand subCommand = Command.GetSubCommand(arg) ?? throw new Exception($"{Command.Name} doesnt have an argument called '{arg}'");
        CArgument cArgument;
        if (1 < input.Length)
        {
            if (subCommand.TakesParameter == false)
                throw new($"{subCommand.Name} does not take parameters");
            cArgument = new(subCommand, StringFormating.RemoveQuotes(input[1]));
        }
        else
        {
            if (subCommand.TakesParameter == true)
                throw new($"{subCommand.Name} takes parameters, but 0 are given");
            cArgument = new(subCommand);
        }

        return cArgument;
    }
}