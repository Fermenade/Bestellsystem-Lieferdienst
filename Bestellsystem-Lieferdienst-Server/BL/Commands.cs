using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using Bestellsystem_Lieferdienst_server.DAL;
using Mysqlx.Crud;
// ReSharper disable UnusedType.Global

namespace Bestellsystem_Lieferdienst_Server.BL;

class Commands
{
    static string _connectionString = "Server=localhost;Database=deliveryservice;Uid=root";
    static DatabaseHelper _dbHelper = new DatabaseHelper(_connectionString);

    public class sql : BaseCommand
    {
        public override string Name => "sql";

        class Select : ICommand
        {
            public string Name => "SELECT";
            public bool? TakesParameter => true;

            public void Execute(string? args)
            {
                _dbHelper.GetDataFromDatabase(args);
            }
        }

        class Insert : ICommand
        {
            public string Name => "INSERT";
            public bool? TakesParameter => true;

            public void Execute(string? args)
            {
                throw new NotImplementedException();
            }
        }

        class Update : ICommand
        {
            public string Name => "UPDATE";
            public bool? TakesParameter => true;

            public void Execute(string? args)
            {
                throw new NotImplementedException();
            }
        }

        class Delete : ICommand
        {
            //So theoretically this is not very safe, but this is still just a 
            public string Name => "DELETE";
            public bool? TakesParameter => true;

            public void Execute(string? args)
            {
                throw new NotImplementedException();

            }
        }
    }

    public class GetPredefined : BaseCommand
    {
        public override string Name => "GET";

        class GetAllProducts : ICommand
        {
            public string Name => "ALLPRODUCTS";
            public bool? TakesParameter => false;

            public void Execute(string? args)
            {
                throw new NotImplementedException();
            }
        }

        class GetProduct : ICommand
        {
            public string Name => "PRODUCT";
            public bool? TakesParameter => false;

            public void Execute(string? args)
            {
                throw new NotImplementedException();
            }
        }

        class GetUser : ICommand
        {
            public string Name { get; }
            public bool? TakesParameter { get; }

            public void Execute(string? command)
            {
                throw new NotImplementedException();
            }
        }
    }

    public class SetPredefined : BaseCommand
    {
        public override string Name => "SET";

        class RegisterUser : ICommand
        {
            public string Name => "USER";
            public bool? TakesParameter => true;

            public void Execute(string? args)
            {
                throw new NotImplementedException();
            }
        }

        class SetProduct : ICommand
        {
            public string Name => "PRODUCT";
            public bool? TakesParameter => true;

            public void Execute(string? command)
            {
                throw new NotImplementedException();
            }
        }

        class SetAddress : ICommand
        {
            public string Name => "ADDRESS";
            public bool? TakesParameter => true;

            public void Execute(string? command)
            {
                throw new NotImplementedException();
            }
        }

        class SetProductGroup : ICommand
        {
            public string Name => "PRODUCTGROUP";
            public bool? TakesParameter => true;

            public void Execute(string? command)
            {
                throw new NotImplementedException();
            }
        }
    }

    public class UpdatePredefined : BaseCommand
    {
        public override string Name => "SET";

        class UpdateUser : ICommand
        {
            public string Name => "USER";
            public bool? TakesParameter => true;

            public void Execute(string? args)
            {
                throw new NotImplementedException();
            }
        }

        class UpdateProduct : ICommand
        {
            public string Name => "PRODUCT";
            public bool? TakesParameter => true;

            public void Execute(string? command)
            {
                throw new NotImplementedException();
            }
        }

        class UpdateAddress : ICommand
        {
            public string Name => "ADDRESS";
            public bool? TakesParameter => true;

            public void Execute(string? command)
            {
                throw new NotImplementedException();
            }
        }

        class UpdateProductGroup : ICommand
        {
            public string Name => "PRODUCTGROUP";
            public bool? TakesParameter => true;

            public void Execute(string? command)
            {
                throw new NotImplementedException();
            }
        }
    }

    public class DeletePredefined : BaseCommand
    {
        public override string Name => "SET";

        class DeleteUser : ICommand
        {
            public string Name => "USER";
            public bool? TakesParameter => true;

            public void Execute(string? args)
            {
                throw new NotImplementedException();
            }
        }

        class DeleteProduct : ICommand
        {
            public string Name => "PRODUCT";
            public bool? TakesParameter => true;

            public void Execute(string? command)
            {
                throw new NotImplementedException();
            }
        }

        class DeleteAddress : ICommand
        {
            public string Name => "ADDRESS";
            public bool? TakesParameter => true;

            public void Execute(string? command)
            {
                throw new NotImplementedException();
            }
        }

        class DeleteProductGroup : ICommand
        {
            public string Name => "PRODUCTGROUP";
            public bool? TakesParameter => true;

            public void Execute(string? command)
            {
                throw new NotImplementedException();
            }
        }
    }

    /// <summary>
    /// The Client wants to check from time to time if the server still exists.
    /// </summary>
    public class Server : BaseCommand
    {
        public override string Name => "server";

        class Ping : ICommand
        {
            public string Name => "ping";
            public bool? TakesParameter => true;

            public void Execute(string? args)
            {
                throw new NotImplementedException();
                //send("client pong")
            }
        }
    }

    /// <summary>
    /// This is just an example for future me.
    /// </summary>
    public class Example : BaseCommand
    {
        public override string Name => "commandname";

        public class ExampleSubcommand : ICommand
        {
            public string Name => "example subcommand name";
            public bool? TakesParameter => false;

            public void Execute(string? args)
            {
                throw new NotImplementedException();
            }
        }
    }
}