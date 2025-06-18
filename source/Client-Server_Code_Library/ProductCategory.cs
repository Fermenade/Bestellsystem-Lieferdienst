namespace Client_Server_Code_Library
{
    public class ProductCategory
    {
        [DatabaseID]
        public int id;
        public string name;

        [DatabaseConstructor]
        public ProductCategory(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public ProductCategory(string name)
        {
            this.name = name;
        }
    }
}
