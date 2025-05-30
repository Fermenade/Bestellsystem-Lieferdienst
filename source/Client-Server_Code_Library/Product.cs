namespace Client_Server_Code_Library;

public class Product
{
    int ProductID;
    string ProductName;
    string ProductDescription;
    int ProductPrice;
    string[] ProductCategories;

    public Product(string productName, string productDescription, int productPrice, string[] productCategories)
    {
        this.ProductName = productName;
        this.ProductDescription = productDescription;
        this.ProductPrice = productPrice;
        this.ProductCategories = productCategories;
    }
    public Product(int productID, string productName, string productDescription, int productPrice, string[] productCategories)
    {
        ProductID = productID;
        ProductName = productName;
        ProductDescription = productDescription;
        ProductPrice = productPrice;
        ProductCategories = productCategories;
    }
}