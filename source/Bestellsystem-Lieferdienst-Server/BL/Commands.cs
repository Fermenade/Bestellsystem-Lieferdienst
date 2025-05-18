using bestellsystem_lieferdienst_server.BL;
using Bestellsystem_Lieferdienst_server.BL;
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
            public object Execute(User user, string? args)
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

            public object Execute(User User, string? args)
            {
                throw new NotImplementedException();
            }
        }

        public class GetProduct : ICommand
        {
            public string Name => "PRODUCT";
            public bool? TakesParameter => false;
            public Usertype MinPrivilegeRequired => Usertype.User;

            public object Execute(User User, string? args)
            {
                throw new NotImplementedException();
            }
        }

        public class GetUser : ICommand
        {
            public string Name { get; }
            public bool? TakesParameter { get; }
            public Usertype MinPrivilegeRequired => Usertype.User;

            public object Execute(User User, string? command)
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

            public object Execute(User user,string? args)
            {
                string tablename = "User";
                if (user == null)
                {
                    User i = JsonSerialize.Deserialize<User>(args); 
                    _dbHelper.InsertItemIntoTable(tablename,i);

                    //TODOMaybe add Unique ID between Client and server when client looses connection. it can send a reconnect command with the ID.
                    return "UserHappened";
                }
                else
                {
                    throw new Exception("Tried to create a new user for a already logged in user.");
                }
            }
        }

        public class SetProduct : ICommand
        {
            public string Name => "PRODUCT";
            public bool? TakesParameter => true;

            public Usertype MinPrivilegeRequired => Usertype.Employee;

            public object Execute(User user, string? args)
            {
                string tablename = "Products";
               Product i = JsonSerialize.Deserialize<Product>(args);
               _dbHelper.InsertItemIntoTable(tablename,i);
               return null;
            }
        }

        public class SetAddress : ICommand
        {
            public string Name => "ADDRESS";
            public bool? TakesParameter => true;
            public Usertype MinPrivilegeRequired => Usertype.Customer;

            public object Execute(User user, string? args)
            {
                string tablename = "Address";
                Address i = JsonSerialize.Deserialize<Address>(args);
                _dbHelper.InsertItemIntoTable(tablename, i);
                return null;
            }
        }

        public class SetProductGroup : ICommand
        {
            public string Name => "PRODUCTGROUP";
            public bool? TakesParameter => true;

            public Usertype MinPrivilegeRequired => Usertype.Employee;

            public object Execute(User user, string? args)
            {
                string tablename = "Products";
                Product i = JsonSerialize.Deserialize<Product>(args);
                _dbHelper.InsertItemIntoTable(tablename, i);
                return null;
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

            public object Execute(User user, string? args)
            {
                throw new NotImplementedException();
            }
        }

        public class UpdateProduct : ICommand
        {
            public string Name => "PRODUCT";
            public bool? TakesParameter => true;

            public Usertype MinPrivilegeRequired => Usertype.Employee;

            public object Execute(User user, string? args)
            {
                throw new NotImplementedException();
            }
        }

        public class UpdateAddress : ICommand
        {
            public string Name => "ADDRESS";
            public bool? TakesParameter => true;

            public Usertype MinPrivilegeRequired => Usertype.Customer;
            public object Execute(User user, string? args)
            {
                throw new NotImplementedException();
            }
        }

        public class UpdateProductGroup : ICommand
        {
            public string Name => "PRODUCTGROUP";
            public bool? TakesParameter => true;

            public Usertype MinPrivilegeRequired => Usertype.Employee;

            public object Execute(User user, string? args)
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

            public object Execute(User user, string? args)
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

            public object Execute(User user, string? args)
            {
                throw new NotImplementedException();
            }
        }

        public class DeleteAddress : ICommand
        {
            public string Name => "ADDRESS";
            public bool? TakesParameter => true;

            public Usertype MinPrivilegeRequired => Usertype.Customer;

            public object Execute(User user, string? args)
            {
                throw new NotImplementedException();
            }
        }

        public class DeleteProductGroup : ICommand
        {
            public string Name => "PRODUCTGROUP";
            public bool? TakesParameter => true;

            public Usertype MinPrivilegeRequired => Usertype.Employee;

            public object Execute(User user, string? args)
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

            public object Execute(User User, string? args)
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
            public object Execute(User User, string? args)
            {
                throw new NotImplementedException();
            }
        }
    }
}