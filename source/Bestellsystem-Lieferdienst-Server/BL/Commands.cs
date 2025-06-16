using Bestellsystem_Lieferdienst_Server.DAL;
using Client_Server_Code_Library;

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

            public object Execute(string? args)
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

            public object Execute(string? args)
            {
                SqlCommand command = new SqlCommand().SelectAll(tableProduct);
                List<Product> products = new List<Product>();
                products.AddRange(_dbHelper.GetDataFromDatabase<Product>(command));

                foreach (var VARIABLE in products)
                {
                    command = new SqlCommand().SelectColumnsByJoin(tableProductGroup, cTableProduct_ProductGroup,
                        ["name"], [("productID", "productgroup.productgroupID")], [("productID", VARIABLE.ID)]);
                    List<string> categories = new();
                    foreach (var VARIABLE1 in _dbHelper.GetDataFromDatabase(command))
                    {
                        categories.Add(VARIABLE1[0].ToString());
                    }
                    VARIABLE.Categories = categories.ToArray();

                    if (VARIABLE.Imagepath != null)
                    {
                        VARIABLE.Picture = File.ReadAllBytes(VARIABLE.Imagepath);
                        VARIABLE.Imagepath = null;
                    }
                }

                return products;
            }
        }

        public class GetAllCategories : ICommand
        {
            public string Name => "ALLCATEGORIES";
            public bool? TakesParameter => false;
            public Usertype MinPrivilegeRequired => Usertype.User;

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
            public Usertype MinPrivilegeRequired => Usertype.User;

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
            public Usertype MinPrivilegeRequired => Usertype.User;

            public object Execute(string? args)
            {
                //TODO: fix so that adress is also read from database.

                User gottenUser = JsonSerialize.Deserialize<User>(args);

                SqlCommand command =
                    new SqlCommand().SelectByNonPredefined(tableUser, [("email", gottenUser.email), ("password", gottenUser.password)]);

                User? user = _dbHelper.GetDataFromID<User>(command);

                if (user == null)
                {
                    return null;
                }
                if (user.address_addressID != null)
                {
                    command = new SqlCommand().SelectById(tableAddress, (int)user.address_addressID);
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
                public Usertype MinPrivilegeRequired => Usertype.User;

                public object Execute(string? args)
                {

                    User i = JsonSerialize.Deserialize<User>(args);

                    Address address = i.Address;
                    SqlCommand command;

                    if (address != null)
                    {
                        command = new SqlCommand().Insert(tableAddress, address);
                        i.address_addressID = _dbHelper.InsertAndReturnID(command, tableAddress);
                    }

                    i.usertypeID = (int)Usertype.Customer;
                    command = new SqlCommand().Insert(tableUser, i);
                    _dbHelper.InsertItemIntoTable(command);


                    return null;
                }
            }

            public class SetProduct : ICommand
            {
                public string Name => "PRODUCT";
                public bool? TakesParameter => true;

                public Usertype MinPrivilegeRequired => Usertype.Employee;

                public object Execute(string? args)
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

                public Usertype MinPrivilegeRequired => Usertype.Employee;

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
                public Usertype MinPrivilegeRequired => Usertype.User;
                public object Execute(string? command)
                {
                    Order order = JsonSerialize.Deserialize<Order>(command);
                    SqlCommand sqlCommand = new SqlCommand().Insert(tableOrder, order.UserID);
                    int orderID = _dbHelper.InsertAndReturnID(sqlCommand, tableOrder);

                    foreach (var VARIABLE in order.Items)
                    {
                        VARIABLE.OrderId = orderID;
                        sqlCommand = new SqlCommand().Insert(tableOrder_Product, VARIABLE);
                        _dbHelper.InsertItemIntoTable(sqlCommand);
                    }
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

                public object Execute(string? args)
                {
                    throw new NotImplementedException();
                }
            }

            public class UpdateProduct : ICommand
            {
                public string Name => "PRODUCT";
                public bool? TakesParameter => true;

                public Usertype MinPrivilegeRequired => Usertype.Employee;

                public object Execute(string? args)
                {
                    throw new NotImplementedException();
                }
            }

            public class UpdateAddress : ICommand
            {
                public string Name => "ADDRESS";
                public bool? TakesParameter => true;

                public Usertype MinPrivilegeRequired => Usertype.Customer;

                public object Execute(string? args)
                {
                    throw new NotImplementedException();
                }
            }

            public class UpdateProductGroup : ICommand
            {
                public string Name => "PRODUCTGROUP";
                public bool? TakesParameter => true;

                public Usertype MinPrivilegeRequired => Usertype.Employee;

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

                public Usertype MinPrivilegeRequired => Usertype.Admin;

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

                public Usertype MinPrivilegeRequired => Usertype.Employee;

                public object Execute(string? args)
                {
                    throw new NotImplementedException();
                }
            }

            public class DeleteAddress : ICommand
            {
                public string Name => "ADDRESS";
                public bool? TakesParameter => true;

                public Usertype MinPrivilegeRequired => Usertype.Customer;

                public object Execute(string? args)
                {
                    throw new NotImplementedException();
                }
            }

            public class DeleteProductGroup : ICommand
            {
                public string Name => "PRODUCTGROUP";
                public bool? TakesParameter => true;

                public Usertype MinPrivilegeRequired => Usertype.Employee;

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
                public Usertype MinPrivilegeRequired => Usertype.User;

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
                public Usertype MinPrivilegeRequired => Usertype.User;

                public object Execute(string? args)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}