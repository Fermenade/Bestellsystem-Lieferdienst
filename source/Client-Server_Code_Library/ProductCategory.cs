using Newtonsoft.Json;

namespace Client_Server_Code_Library
{
    public class ProductCategory
    {
        [DatabaseAutoIncrementID]
        public int id;
        public string name;

        [DatabaseConstructor]
        [JsonConstructor]
        public ProductCategory(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public ProductCategory(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
