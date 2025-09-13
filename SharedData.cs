using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket__project
{
    public static class SharedData
    {
        public static Product[] addedProducts = new Product[100];
        public static int productCount = 0;

        public static Product[] meatProducts = new Product[100];
        public static int meatCount = 0;

        public static Product[] drinkProducts = new Product[100];
        public static int drinkCount = 0;

    }
}
