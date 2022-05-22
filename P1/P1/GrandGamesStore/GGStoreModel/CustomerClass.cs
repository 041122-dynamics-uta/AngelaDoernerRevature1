using System.Data.SqlClient;
using GGStoreModel;
namespace GGStoreModel
{
    public class CustomerClass
    {
        public int CustomerID { get; set; } 
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public int Pswd { get; set; } = 0;
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
    
}