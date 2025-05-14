using bestellsystem_lieferdienst_server.BL;
using System.Diagnostics.CodeAnalysis;

namespace Bestellsystem_Lieferdienst_Server.BL;

[SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
public class UserCommand
{
    public class ArgumentList
    {
        public User User;
        public CArgument[] Arguments;

        public ArgumentList(User User, CArgument[] arguments)
        {
            this.User = User;
            this.Arguments = arguments;
        }
        public class CArgument
        {
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

        }

    }

    public BaseCommand Command { get; private set; }

    public ArgumentList? Arguments { get; private set; }

    public UserCommand(User? User, string command)
    {
        if (string.IsNullOrWhiteSpace(command)) throw new Exception("Not a valid Command");
        if (command.Length == 0) throw new Exception("Not a valid Command");


        string[]
            parts = StringFormating
                .Explode(command); //TODO: das explode sorgt auch dafür, dass der prefix "-" nicht mehr als ein einzelnes element angesehen wird

        this.Command = (BaseCommand)CommandManager.GetBaseCommand(parts[0]) ?? throw new Exception("Not a valid Command");
        this.Arguments = new(User, ParseAllArguments(parts.Skip(1).ToArray()));
    }

    ArgumentList.CArgument[]? ParseAllArguments(string[] input)
    {
        List<ArgumentList.CArgument> arguments = new List<ArgumentList.CArgument>();
        for (int i = 0; i < input.Length; i++)
        {
            string arg = StringFormating.RemoveQuotes(input[i]);

            ICommand subCommand = Command.GetSubCommand(arg) ?? throw new Exception($"{Command.Name} doesnt have an argument called '{arg}'");
            if (i + 1 < input.Length)
            {
                if (subCommand.TakesParameter == false)
                    throw new($"{subCommand.Name} does not take parameters");
                i++; //So that the parameter gets ignored
                ArgumentList.CArgument cArgument = new(subCommand, StringFormating.RemoveQuotes(input[i]));
                arguments.Add(cArgument);
            }
            else
            {
                if (subCommand.TakesParameter == true)
                    throw new($"{subCommand.Name} takes parameters, but 0 are given");
                ArgumentList.CArgument cArgument = new(subCommand);
                arguments.Add(cArgument);
            }
        }

        return arguments.ToArray();
    }
}