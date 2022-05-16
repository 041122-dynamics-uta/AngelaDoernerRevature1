using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneModels
{
    public class Member
    {
        public int CostumerId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public List<Order> _orders;


        public Member()
        {
            CostumerId = 0;
            Name = ".Name";
            Phone = ".Phone";
            Address = ".Address";
            Email = ".Email";
            _orders = new List<Order>();
        }

    }