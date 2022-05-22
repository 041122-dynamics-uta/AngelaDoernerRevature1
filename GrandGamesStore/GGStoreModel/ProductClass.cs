using System.Data.SqlClient;

namespace DigitalRecordStoreModel
{
    public class ProductClass
    {
        public int? ProductID { get; set; } = 0;
        public ProductClass(string name, int price, string description, int quantity, int storeID, string artist)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Quantity = quantity;
            this.StoreID = storeID;
            this.Artist = artist;

        }
        public string Name { get; set; } = "";
        public int Price { get; set; } = 0;
        public string Description { get; set; } = "";
        public int Quantity { get; set; } = 0;
        public int StoreID { get; set; } = 0;
        public string Artist { get; set; } = "";
    }
}