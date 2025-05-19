using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem_Lieferdienst.BL.Datatypes
{
    public class Receipe
    {
        int ReceipeID;
        int UserID;
        private int[] productsID;
        DateTime Datum;

        private string Übergabeort;
        //TODO: Product should be quantisisable :)
    }
}
