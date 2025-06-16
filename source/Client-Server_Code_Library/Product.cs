using Newtonsoft.Json;

namespace Client_Server_Code_Library;

public class Product
{
    public int ID;
    public string Name;
    public string Description;
    public decimal Price;
    public string[] Categories;
    public string? Imagepath;

    [IgnoreInsert]
    public byte[]? Picture;//cuz it's easier.

    public Product(string name, string description, decimal price, string[] categories, byte[] picture)
    {
        this.Name = name;
        this.Description = description;
        this.Price = price;
        this.Categories = categories;
        this.Picture = picture;
    }
    [DatabaseConstructor]
    public Product(int id, string name, string description, decimal price, string imagepath)
    {
        ID = id;
        Name = name;
        Description = description;
        Price = price;
    }
    [JsonConstructor]
    public Product(int id, string name, string description, decimal price, string[] categories, byte[] picture)
    {
        if (id == -1)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Categories = categories;
            this.Picture = picture;
        }
        else
        {
            ID = id;
            Name = name;
            Description = description;
            Price = price;
            Categories = categories;
        }
    }

    public static Product CreateProduct(int id, string name, string description, string price, byte[] picture, string[] categories)
    {
        if (!decimal.TryParse(price, out decimal Price))
        {
            throw new Exception("Price is not of type decimal");
        }

        return new(id,name, description, Price, categories, picture);
    }
}