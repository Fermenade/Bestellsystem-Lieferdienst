namespace Client_Server_Code_Library;
public class ProductCategory
{
    public int? CategoryID;
    public string CategoryName;
    public ProductCategory(string categoryName)
    {
        this.CategoryName = categoryName;
    }
    public ProductCategory(int CategoryId, string categoryName)
    {
        this.CategoryID = CategoryId;
        this.CategoryName = categoryName;
    }

}
