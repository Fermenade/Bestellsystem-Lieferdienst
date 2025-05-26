using Bestellsystem_Lieferdienst_Server.DAL;
using Client_Server_Code_Library;

// ReSharper disable UnusedType.Global

namespace Bestellsystem_Lieferdienst_Server.BL;

public class Commands
{
    static string _connectionString = "Server=localhost;Database=deliveryservice;Uid=root";
    static DatabaseHelper _dbHelper = new DatabaseHelper(_connectionString);

    public static string tableProduct = "product";
    public static string tableProductGroup = "productgroup";
    public static string tableOrder = "order";
    public static string tableAddress = "address";
    public static string tableUsertype = "usertype";
    public static string tableUser = "user";

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
                SqlCommand command = new SqlCommand().SelectAll(tableProduct);
                return _dbHelper.GetDataFromDatabase<Product>(command);
            }
        }
        public class GetAllCategories : ICommand
        {
            public string Name => "ALLCATEGORIES";
            public bool? TakesParameter => false;
            public Usertype MinPrivilegeRequired => Usertype.User;

            public object Execute(User User, string? args)
            {
                SqlCommand command = new SqlCommand().SelectAll(tableProductGroup);
                List<string> categorielist = [];
                foreach (var VARIABLE in _dbHelper.GetDataFromDatabase(command))
                {
                    categorielist.Add(VARIABLE[1].ToString());
                }
                return categorielist.ToArray();
            }
        }
        public class GetProduct : ICommand
        {
            public string Name => "PRODUCT";
            public bool? TakesParameter => true;
            public Usertype MinPrivilegeRequired => Usertype.User;

            public object Execute(User User, string? args)
            {
                SqlCommand command = new SqlCommand().SelectById(tableProduct, int.Parse(args));
                return _dbHelper.GetDataFromID<Product>(command);
            }
        }

        public class GetUser : ICommand
        {
            public string Name => "USER";
            public bool? TakesParameter => true;
            public Usertype MinPrivilegeRequired => Usertype.User;

            public object Execute(User User, string? args)
            {
                //TODO: fix so that adress is also read from database.
                string[] i = args.Split(" ");
                if (i.Length != 2) throw new Exception("User must takes two arguments");

                SqlCommand command = new SqlCommand().SelectByNonPredefined(tableUser, [("email", i[0]), ("password", i[1])]);

                return _dbHelper.GetDataFromDatabase<User>(command);
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

            public object Execute(User user, string? args)
            {
                if (user == null)
                {
                    User i = JsonSerialize.Deserialize<User>(args);
                    SqlCommand command = new SqlCommand().Insert(tableUser, i);
                    _dbHelper.InsertItemIntoTable(command);

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
                Product i = JsonSerialize.Deserialize<Product>(args);
                SqlCommand command = new SqlCommand().Insert(tableProduct, i);
                _dbHelper.InsertItemIntoTable(command);

                return 1;
            }
        }

        public class SetAddress : ICommand
        {
            public string Name => "ADDRESS";
            public bool? TakesParameter => true;
            public Usertype MinPrivilegeRequired => Usertype.Customer;

            public object Execute(User user, string? args)
            {
                Address i = JsonSerialize.Deserialize<Address>(args);
                SqlCommand command = new SqlCommand().Insert(tableAddress, i);
                _dbHelper.InsertItemIntoTable(command);

                return 1;
            }
        }

        public class SetProductGroup : ICommand
        {
            public string Name => "PRODUCTGROUP";
            public bool? TakesParameter => true;

            public Usertype MinPrivilegeRequired => Usertype.Employee;

            public object Execute(User user, string? args)
            {
                Product i = JsonSerialize.Deserialize<Product>(args);
                SqlCommand command = new SqlCommand().Insert(tableProductGroup, i);
                _dbHelper.InsertItemIntoTable(command);

                return 1;
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
            public bool? TakesParameter => false;
            public Usertype MinPrivilegeRequired => Usertype.User;

            public object Execute(User User, string? args)
            {
                return "pong";
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