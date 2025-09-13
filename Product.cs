using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket__project
{

    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int Amount { get; set; }

        public virtual void GetProductDetails()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Category: {Category}, Price: {Price}");
        }
    }
}
