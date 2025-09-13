using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Supermarket__project
{
    internal class Drinks_class : Product
    {
        public enum DrinkSize
    {
        Small = 250,
        Medium = 500,
        Large = 1000
    }
    public enum DrinkType
    {
        Cola,
        Juice,
        Water
    }
    public DrinkSize Size { get; set; }
    public DrinkType Type { get; set; }
        public override void GetProductDetails()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Category: {Category}, Price: {Price}, Type: {Type}, Size: {(int)Size}ml");
        }
    }
}
