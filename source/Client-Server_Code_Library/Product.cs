using Newtonsoft.Json;
using System.Diagnostics.Metrics;

namespace Client_Server_Code_Library;

public class Product
{
    [DatabaseAutoIncrementID]
    public long? ProductId;
    public string Name;
    public string Description;
    public decimal Price;
    [IgnoreInsert]
    public string[]? Categories;
    public string? ImagePath;

    [IgnoreInsert]
    public byte[]? Picture;//cuz it's easier.

    public Product(string name, string description, decimal price, string[]? categories, byte[] picture)
    {
        if (name == "") throw new("Invalid name");
        this.Name = name;
        if (description == "") throw new Exception("Invalid description");
        this.Description = description;
        if (price == 0) throw new Exception("Price was 0");
        this.Price = price;
        this.Categories = categories;
        if (picture == null) throw new Exception("Picture was null");
        this.Picture = picture;
    }
    [DatabaseConstructor]
    public Product(int productId, string name, string description, decimal price, string imagepath)
    {
        ProductId = productId;
        Name = name;
        Description = description;
        Price = price;
        ImagePath = imagepath;
    }
    [JsonConstructor]
    public Product(long? productId, string name, string description, decimal price, string[] categories, byte[] picture)
    {
        this.Name = name;
        this.Description = description;
        this.Price = price;
        this.Categories = categories;
        this.Picture = picture;
    }

    protected Product()
    {
        //This has to be empty
    }

    public static Product CreateProduct(int id, string name, string description, string price, byte[] picture, string[] categories)
    {
        if (!decimal.TryParse(price, out decimal Price))
        {
            throw new Exception("Price is not of type decimal");
        }

        return new(id, name, description, Price, categories, picture);
    }
    public static Product CreateProduct(string name, string description, string price, byte[] picture, string[] categories)
    {
        if (!decimal.TryParse(price, out decimal Price))
        {
            throw new Exception("Price is not of type decimal");
        }

        return new(name, description, Price, categories, picture);
    }

    public override string ToString()
    {
        return JsonSerialize.Serialize(this);
    }
}