using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem_Lieferdienst.BL.Datatypes
{
    public class Product
    {
        int ProductID;
        string ProductName;
        string ProductDescription;
        int ProductPrice;
        ProductCategory[] ProductCategories;
    }
}
