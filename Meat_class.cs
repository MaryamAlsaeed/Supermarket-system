using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket__project
{
    internal class Meat_class : Product
    {
        public enum MeatSize
        {
            kilo = 1,
            twokilo = 2,
            threekilo = 3
        }
        public enum MeatType
        {
            salmon,
            ChickenBreast,
            GroundBeef
        }

        public MeatSize Size { get; set; }
        public MeatType Type { get; set; }
        public override void GetProductDetails()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Category: {Category}, Price: {Price}, Type: {Type}, Size: {(int)Size}Kg");
        }
    }
  }
