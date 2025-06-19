using Bestellsystem_Lieferdienst_Server.BL.Datatypes;
using Bestellsystem_Lieferdienst_Server.DAL;
using Client_Server_Code_Library;
using System.Diagnostics.CodeAnalysis;
using System.Text;

// ReSharper disable UnusedType.Global

namespace Bestellsystem_Lieferdienst_Server.BL;

public class Commands
{
    const string _connectionString = "Server=localhost;Database=deliveryservice;Uid=root";
    static DatabaseHelper _dbHelper = new(_connectionString);

    public const string tableProduct = "product";
    public const string tableProductGroup = "productgroup";
    public const string cTableProduct_ProductGroup = "product_has_productgroup";
    public const string tableOrder = "order";
    public const string tableOrder_Product = "order_has_product";
    public const string tableAddress = "address";
    public const string tableUsertype = "usertype";
    public const string tableUser = "user";

    public const string AssetsFolderPath = "Assets";

    public class Help : BaseCommand
    {
        public override string Name => "help";

        public class Search : ICommand
        {
            public string Name => "search";
            public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.Admin;
            public bool? TakesParameter => true;

            public object Execute(string? args)
            {

                var s = StringFormating.Explode(args);
                string endresult = "";
                foreach (string command in s)
                {
                    BaseCommand? baseCommand = (BaseCommand?)CommandManager.GetBaseCommand(command);

                    endresult += ShowHelp(baseCommand);
                }
                return endresult;
            }

            /// <summary>
            /// Get entire subcommand list of command
            /// </summary>
            /// <param name="command"></param>
            /// <returns>Returns entire subcommand list of command</returns>
            string ShowHelp(BaseCommand command)
            {
                StringBuilder help = new StringBuilder();
                help.AppendLine("Available arguments:");
                foreach (ICommand subCommand in command.SubCommands)
                {
                    help.AppendLine($"{subCommand.Name}");
                }

                return help.ToString();
            }
        }

        [SuppressMessage("ReSharper", "UnusedMethodReturnValue.Local")]
        public class All : ICommand
        {
            public string Name => "all";
            public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.Admin;
            public bool? TakesParameter => null;

            public object Execute(string? args)
            {
                StringBuilder help = new StringBuilder();
                help.AppendLine("'!command' argument [parameter]");
                help.AppendLine("Available commands:");
                if (args != null)
                {
                    var s = StringFormating.Explode(args); //This is because when "command" does contain "command "command command""
                    ShowHelp(help, s);
                }
                else
                {
                    //help = ShowAllHelp(help); 
                    ShowAllHelp(help);
                }

                return help.ToString();
            }
            static StringBuilder ShowHelp(StringBuilder help, string[] command)
            {
                foreach (var VARIABLE in command)
                {
                    var i = (BaseCommand)CommandManager.GetBaseCommand(VARIABLE);
                    if (i == null)
                    {
                        help.AppendLine($"{VARIABLE} unknown command");
                        continue;
                    }
                    ShowAllHelp(help, i);
                }
                return help;
            }

            /// <summary>
            /// Shows entire command list
            /// </summary>
            /// <returns>Returns list of all available commands</returns>
            static void ShowAllHelp(StringBuilder help)
            {
                foreach (BaseCommand command in CommandManager.Commands)
                {
                    ShowAllHelp(help, command);
                }
            }

            static void ShowAllHelp(StringBuilder help, BaseCommand command)
            {
                help.AppendLine($"{command.Name}");
                foreach (ICommand VARIABLE in command.SubCommands)
                {
                    help.AppendLine($"\t{VARIABLE.Name} min priv lvl: {VARIABLE.MinPrivilegeRequired}, takes Params: {VARIABLE.TakesParameter}");
                }
            }
        }
    }
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
            public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.Admin;

            public object Execute(string? args)
            {
                //Dont have time for the rest.
                if (args.Split(" ")[0] != "SELECT")
                {
                    _dbHelper.ExecutePlainNonQuery(args);
                }

                return "Succsessful";
            }
        }
    }
    public class predefinedAdminCommands : BaseCommand
    {
        public override string Name => "!";


        public class ExecSqlCommand : ICommand
        {
            public string Name => "clearall";
            public bool? TakesParameter => false;
            public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.Admin;

            public object Execute(string? args)
            {
                var i = Directory.GetFiles(AssetsFolderPath);
                foreach (var VARIABLE in i)
                {
                    File.Delete(VARIABLE);
                }

                SqlCommand command = new SqlCommand().DeleteAllFromTable(tableOrder);
                _dbHelper.InsertItemIntoTable(command);
                return "Cleared Assets Folder ad";
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
            public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.User;

            public object Execute(string? args)
            {
                SqlCommand command = new SqlCommand().SelectAll(tableProduct);
                List<Product> products = new List<Product>();
                products.AddRange(_dbHelper.GetDataFromDatabase<Product>(command));

                foreach (var VARIABLE in products)
                {
                    command = new SqlCommand().SelectColumnsByJoin(tableProductGroup, cTableProduct_ProductGroup,
                        ["*"], [("productID", "productgroup.productgroupID")], [("productID", VARIABLE.ProductId)]);
                    List<ProductCategory> categories = new();
                    foreach (var VARIABLE1 in _dbHelper.GetDataFromDatabase<ProductCategory>(command))
                    {
                        categories.Add(VARIABLE1);
                    }
                    VARIABLE.Categories = categories.ToArray();

                    if (VARIABLE.ImagePath != null)
                    {
                        VARIABLE.Picture = File.ReadAllBytes(VARIABLE.ImagePath);
                        VARIABLE.ImagePath = null;
                    }
                }

                return products;
            }
        }

        public class GetAllCategories : ICommand
        {
            public string Name => "ALLCATEGORIES";
            public bool? TakesParameter => false;
            public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.User;

            public object Execute(string? args)
            {
                SqlCommand command = new SqlCommand().SelectAll(tableProductGroup);

                return _dbHelper.GetDataFromDatabase<ProductCategory>(command);
            }
        }

        public class GetProduct : ICommand
        {
            public string Name => "PRODUCT";
            public bool? TakesParameter => true;
            public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.User;

            public object Execute(string? args)
            {
                SqlCommand command = new SqlCommand().SelectById(tableProduct, int.Parse(args));
                return _dbHelper.GetDataFromID<Product>(command);
            }
        }

        public class GetUser : ICommand
        {
            public string Name => "USER";
            public bool? TakesParameter => true;
            public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.User;

            public object Execute(string? args)
            {
                //TODO: fix so that adress is also read from database.

                User gottenUser = JsonSerialize.Deserialize<User>(args);

                SqlCommand command =
                    new SqlCommand().SelectByNonPredefined(tableUser, [("Email", gottenUser.Email), ("Password", gottenUser.Password)]);

                User? user = _dbHelper.GetDataFromID<User>(command);

                if (user == null)
                {
                    return null;
                }
                if (user.Address_addressID != null)
                {
                    command = new SqlCommand().SelectById(tableAddress, (int)user.Address_addressID);
                    user.Address = _dbHelper.GetDataFromID<Address>(command);
                }

                return user;
            }
        }

        public class SetPredefined : BaseCommand
        {
            public override string Name => "SET";

            public class RegisterUser : ICommand
            {
                public string Name => "USER";
                public bool? TakesParameter => true;
                public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.User;

                public object Execute(string? args)
                {
                    User i = JsonSerialize.Deserialize<User>(args);

                    Address address = i.Address;
                    SqlCommand command;

                    if (address != null)
                    {
                        command = new SqlCommand().Insert(tableAddress, address);
                        i.Address_addressID = _dbHelper.InsertItemIntoTable(command);
                    }
                    i.UsertypeID = (int)PredefinedUserAccessLvl.Customer;
                    command = new SqlCommand().Insert(tableUser, i);
                    long id = _dbHelper.InsertItemIntoTable(command);


                    command = new SqlCommand().SelectById(tableUser, id);
                    User user = _dbHelper.GetDataFromID<User>(command)!;

                    if (user.Address_addressID != null)
                    {
                        command = new SqlCommand().SelectById(tableAddress, (int)user.Address_addressID);
                        user.Address = _dbHelper.GetDataFromID<Address>(command);
                    }

                    return user;
                }
            }

            public class SetProduct : ICommand
            {
                public string Name => "PRODUCT";
                public bool? TakesParameter => true;

                public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.Employee;

                public object Execute(string? args)
                {
                    Product i = JsonSerialize.Deserialize<Product>(args);

                    if (i.Picture == null)
                    {
                        //This should never happen, but idk.
                        throw new Exception("Picture was null of Product");
                    }

                    if (!Directory.Exists(AssetsFolderPath))
                    {
                        Directory.CreateDirectory(AssetsFolderPath);
                    }

                    string filename = Guid.CreateVersion7().ToString();
                    string filesFilepath = $"{AssetsFolderPath}\\{filename}";

                    i.ImagePath = filesFilepath;

                    SqlCommand command = new SqlCommand().Insert(tableProduct, i);
                    long productid = _dbHelper.InsertItemIntoTable(command);
                    File.WriteAllBytes(filesFilepath, i.Picture);

                    //this gets more data from the database, but this is faster.
                    command = new SqlCommand().SelectAll(tableProductGroup);
                    ProductCategory[] categories = _dbHelper.GetDataFromDatabase<ProductCategory>(command);

                    foreach (ProductCategory categorie in i.Categories)
                    {
                        // Check if there is a match in the categories array
                        var matchingItem = categories.FirstOrDefault(VARIABLE => VARIABLE.name == categorie.name);

                        if (matchingItem != null)
                        {
                            // Handle the case where categories contains the name
                            Product_Productgroup n = new Product_Productgroup(productid, matchingItem.id);
                            command = new SqlCommand().Insert(cTableProduct_ProductGroup, n);
                            _dbHelper.InsertItemIntoTable(command);
                        }
                        else
                        {
                            // Handle the case where categories does not contain the name
                            command = new SqlCommand().Insert(tableProductGroup, categorie);
                            long groupid = _dbHelper.InsertItemIntoTable(command);

                            Product_Productgroup n = new Product_Productgroup(productid, groupid);
                            command = new SqlCommand().Insert(cTableProduct_ProductGroup, n);
                            _dbHelper.InsertItemIntoTable(command);
                        }
                    }


                    return true;
                }
            }

            public class SetAddress : ICommand
            {
                public string Name => "ADDRESS";
                public bool? TakesParameter => true;
                public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.Customer;

                public object Execute(string? args)
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

                public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.Employee;

                public object Execute(string? args)
                {
                    Product i = JsonSerialize.Deserialize<Product>(args);
                    SqlCommand command = new SqlCommand().Insert(tableProductGroup, i);
                    _dbHelper.InsertItemIntoTable(command);

                    return 1;
                }
            }
            public class SetOrder : ICommand
            {
                public string Name => "ORDER";
                public bool? TakesParameter => true;
                public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.User;
                public object Execute(string? command)
                {
                    Order order = JsonSerialize.Deserialize<Order>(command);
                    SqlCommand sqlCommand = new SqlCommand().Insert(tableOrder, order.UserID);
                    long orderID = _dbHelper.InsertItemIntoTable(sqlCommand);

                    foreach (var VARIABLE in order.Items)
                    {
                        VARIABLE.OrderId = orderID;
                        sqlCommand = new SqlCommand().Insert(tableOrder_Product, VARIABLE);
                        _dbHelper.InsertItemIntoTable(sqlCommand);
                    }
                    return true;
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
                public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.Customer;

                public object Execute(string? args)
                {
                    throw new NotImplementedException();
                }
            }

            public class UpdateProduct : ICommand
            {
                public string Name => "PRODUCT";
                public bool? TakesParameter => true;

                public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.Employee;

                public object Execute(string? args)
                {
                    throw new NotImplementedException();
                }
            }

            public class UpdateAddress : ICommand
            {
                public string Name => "ADDRESS";
                public bool? TakesParameter => true;

                public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.Customer;

                public object Execute(string? args)
                {
                    throw new NotImplementedException();
                }
            }

            public class UpdateProductGroup : ICommand
            {
                public string Name => "PRODUCTGROUP";
                public bool? TakesParameter => true;

                public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.Employee;

                public object Execute(string? args)
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

                public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.Admin;

                public object Execute(string? args)
                {
                    //Feature not planed
                    throw new NotImplementedException();
                }
            }

            public class DeleteProduct : ICommand
            {
                public string Name => "PRODUCT";
                public bool? TakesParameter => true;

                public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.Employee;

                public object Execute(string? args)
                {
                    throw new NotImplementedException();
                }
            }

            public class DeleteAddress : ICommand
            {
                public string Name => "ADDRESS";
                public bool? TakesParameter => true;

                public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.Customer;

                public object Execute(string? args)
                {
                    throw new NotImplementedException();
                }
            }

            public class DeleteProductGroup : ICommand
            {
                public string Name => "PRODUCTGROUP";
                public bool? TakesParameter => true;

                public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.Employee;

                public object Execute(string? args)
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
                public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.User;

                public object Execute(string? args)
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
                public PredefinedUserAccessLvl MinPrivilegeRequired => PredefinedUserAccessLvl.User;

                public object Execute(string? args)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}