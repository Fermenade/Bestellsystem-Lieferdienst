using System.Runtime.CompilerServices;
using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst.BL;

public class ExtendedProduct:Product
{
    private ExtendedProduct()
    {
        Name = "";
        ProductDescription = "";
        Price = 0;
        Categories = [];
        Picture = null;
    }
    public static Product CreateNewProduct() => new ExtendedProduct();
}