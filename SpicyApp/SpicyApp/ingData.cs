using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Mirrors data of ingredients

/**========================*
 * Development Version 2.1 *
 * 
 */
namespace SpicyApp
{
    class ingData
    {
        private string name, unit;
        private int quantity;
        private float spicyness;

        //Constructor
        public ingData(string n = "Unknown Name", int q = 0, string u = "Unknown Unit", float s = 0)
        {
            name = n;
            quantity = q;
            unit = u;
            spicyness = s;
        }

        //Setter and Getter properties
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Unit { get => unit; set => unit = value; }
        public float Spicyness { get => spicyness; set => spicyness = value; }
    }
}
