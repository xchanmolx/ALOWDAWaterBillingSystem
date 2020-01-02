using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WaterBillingSystemUI.BLL
{
    public class UserBLL
    {
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime Added_Date { get; set; }
    }
}
