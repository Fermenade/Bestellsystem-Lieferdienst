using Newtonsoft.Json;
using System.Diagnostics.Metrics;

namespace Client_Server_Code_Library;

public class Product
{
    [DatabaseAutoIncrementID]
    public long? ProductId;
    public string Name;
    public string ProductDescription;
    public decimal Price;
    public string[]? Categories;
    public string? Imagepath;

    [IgnoreInsert]
    public byte[]? Picture;//cuz it's easier.

    public Product(string name, string productDescription, decimal price, string[]? categories, byte[] picture)
    {
        if (name == "") throw new("Invalid name");
        this.Name = name;
        if (productDescription == "") throw new Exception("Invalid productDescription");
        this.ProductDescription = productDescription;
        if (price == 0) throw new Exception("Price was 0");
        this.Price = price;
        this.Categories = categories;
        if (picture == null) throw new Exception("Picture was null");
        this.Picture = picture;
    }
    [DatabaseConstructor]
    public Product(int productId, string name, string productDescription, decimal price, string imagepath)
    {
        ProductId = productId;
        Name = name;
        ProductDescription = productDescription;
        Price = price;
    }
    [JsonConstructor]
    public Product(long? productId, string name, string productDescription, decimal price, string[] categories, byte[] picture)
    {
        if (productId == -1)
        {
            this.Name = name;
            this.ProductDescription = productDescription;
            this.Price = price;
            this.Categories = categories;
            this.Picture = picture;
        }
        else
        {
            ProductId = productId;
            Name = name;
            ProductDescription = productDescription;
            Price = price;
            Categories = categories;
        }
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