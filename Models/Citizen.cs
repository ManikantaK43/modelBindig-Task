using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model_Binding.Models
{
    public class Citizen
    {
        public int AadhaarNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ContactNumber { get; set; }
        public string Email { get; set; }
        public string PanNumber { get; set; }
    }
}