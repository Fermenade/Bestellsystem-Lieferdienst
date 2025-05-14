using bestellsystem_lieferdienst_server.BL;
using Bestellsystem_Lieferdienst_server.DAL;

// ReSharper disable UnusedType.Global

namespace Bestellsystem_Lieferdienst_Server.BL;

public class Commands
{
    static string _connectionString = "Server=localhost;Database=deliveryservice;Uid=root";
    static DatabaseHelper _dbHelper = new DatabaseHelper(_connectionString);

    public class sql : BaseCommand
    {
        public override string Name => "sql";
        /// <summary>
        /// Executes a sql command and returns all it's values.
        /// This command requires Admin or above privileges.
        /// </summary>
        public class ExecSqlCommand : ICommand
        {
            public string Name => "exec";
            public bool? TakesParameter => true;
            public Usertype MinPrivilegeRequired => Usertype.Admin;
            public void Execute(User user, string? args)
            {
                throw new NotImplementedException();
            }
        }
    }

    public class GetPredefined : BaseCommand
    {
        public override string Name => "GET";

        public class GetAllProducts : ICommand
        {
            public string Name => "ALLPRODUCTS";
            public bool? TakesParameter => false;
            public Usertype MinPrivilegeRequired => Usertype.User;

            public void Execute(User User, string? args)
            {
                throw new NotImplementedException();
            }
        }

        public class GetProduct : ICommand
        {
            public string Name => "PRODUCT";
            public bool? TakesParameter => false;
            public Usertype MinPrivilegeRequired => Usertype.User;

            public void Execute(User User, string? args)
            {
                throw new NotImplementedException();
            }
        }

        public class GetUser : ICommand
        {
            public string Name { get; }
            public bool? TakesParameter { get; }
            public Usertype MinPrivilegeRequired => Usertype.User;

            public void Execute(User User, string? command)
            {
                throw new NotImplementedException();
            }
        }
    }

    public class SetPredefined : BaseCommand
    {
        public override string Name => "SET";

        public class RegisterUser : ICommand
        {
            public string Name => "USER";
            public bool? TakesParameter => true;
            public Usertype MinPrivilegeRequired => Usertype.User;

            public void Execute(User user,string? args)
            {
                if (user == null)
                {
                    //Insert
                }
                else
                {
                    //User (probably) Exists
                }

                throw new NotImplementedException();
            }
        }

        public class SetProduct : ICommand
        {
            public string Name => "PRODUCT";
            public bool? TakesParameter => true;

            public Usertype MinPrivilegeRequired => Usertype.Employee;

            public void Execute(User user, string? args)
            {
                throw new NotImplementedException();
            }
        }

        public class SetAddress : ICommand
        {
            public string Name => "ADDRESS";
            public bool? TakesParameter => true;
            public Usertype MinPrivilegeRequired => Usertype.Customer;

            public void Execute(User user, string? args)
            {
                throw new NotImplementedException();
            }
        }

        public class SetProductGroup : ICommand
        {
            public string Name => "PRODUCTGROUP";
            public bool? TakesParameter => true;

            public Usertype MinPrivilegeRequired => Usertype.Employee;

            public void Execute(User user, string? args)
            {
                throw new NotImplementedException();
            }
        }
    }

    public class UpdatePredefined : BaseCommand
    {
        public override string Name => "UPDATE";

        public class UpdateUser : ICommand
        {
            public string Name => "USER";
            public bool? TakesParameter => true;
            public Usertype MinPrivilegeRequired => Usertype.Customer;

            public void Execute(User user, string? args)
            {
                throw new NotImplementedException();
            }
        }

        public class UpdateProduct : ICommand
        {
            public string Name => "PRODUCT";
            public bool? TakesParameter => true;

            public Usertype MinPrivilegeRequired => Usertype.Employee;

            public void Execute(User user, string? args)
            {
                throw new NotImplementedException();
            }
        }

        public class UpdateAddress : ICommand
        {
            public string Name => "ADDRESS";
            public bool? TakesParameter => true;

            public Usertype MinPrivilegeRequired => Usertype.Customer;
            public void Execute(User user, string? args)
            {
                throw new NotImplementedException();
            }
        }

        public class UpdateProductGroup : ICommand
        {
            public string Name => "PRODUCTGROUP";
            public bool? TakesParameter => true;

            public Usertype MinPrivilegeRequired => Usertype.Employee;

            public void Execute(User user, string? args)
            {
                throw new NotImplementedException();
            }
        }
    }

    public class DeletePredefined : BaseCommand
    {
        public override string Name => "DELETE";

        public class DeleteUser : ICommand
        {
            public string Name => "USER";
            public bool? TakesParameter => true;

            public Usertype MinPrivilegeRequired => Usertype.Admin;

            public void Execute(User user, string? args)
            {
                //Feature not planed
                throw new NotImplementedException();
            }
        }

        public class DeleteProduct : ICommand
        {
            public string Name => "PRODUCT";
            public bool? TakesParameter => true;

            public Usertype MinPrivilegeRequired => Usertype.Employee;

            public void Execute(User user, string? args)
            {
                throw new NotImplementedException();
            }
        }

        public class DeleteAddress : ICommand
        {
            public string Name => "ADDRESS";
            public bool? TakesParameter => true;

            public Usertype MinPrivilegeRequired => Usertype.Customer;

            public void Execute(User user, string? args)
            {
                throw new NotImplementedException();
            }
        }

        public class DeleteProductGroup : ICommand
        {
            public string Name => "PRODUCTGROUP";
            public bool? TakesParameter => true;

            public Usertype MinPrivilegeRequired => Usertype.Employee;

            public void Execute(User user, string? args)
            {
                //Feature not planned.
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

        public class Ping : ICommand
        {
            public string Name => "ping";
            public bool? TakesParameter => true;
            public Usertype MinPrivilegeRequired => Usertype.User;

            public void Execute(User User, string? args)
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
            public Usertype MinPrivilegeRequired => Usertype.User;
            public void Execute(User User, string? args)
            {
                throw new NotImplementedException();
            }
        }
    }
}