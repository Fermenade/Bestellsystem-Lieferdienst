namespace Client_Server_Code_Library;

public class Product
{
    public int ID;
    public string Name;
    public string Description;
    public decimal Price;
    public string[] Categories;

    public Product(string name, string description, decimal price, string[] categories)
    {
        this.Name = name;
        this.Description = description;
        this.Price = price;
        this.Categories = categories;
    }
    public Product(int id, string name, string description, decimal price)
    {
        ID = id;
        Name = name;
        Description = description;
        Price = price;
    }
    public Product(int id, string name, string description, decimal price, string[] categories)
    {
        ID = id;
        Name = name;
        Description = description;
        Price = price;
        Categories = categories;
    }
}