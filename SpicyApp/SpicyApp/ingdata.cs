using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyApp
{
    class ingData
    {
        private string name, unit;
        private int quantity;

        //Constructor
        public ingData(string n = "Unknown Name", int q = 0, string u = "Unknown Unit")
        {
            name = n;
            quantity = q;
            unit = u;
        }

        //Setter and Getter properties
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Unit { get => unit; set => unit = value; }
    }
}
