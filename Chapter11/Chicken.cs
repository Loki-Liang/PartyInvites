using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter11Ex01
{
    public class Chicken:Animal
    {
        public void LayEgg()
        {
            Console.WriteLine($"{name} has laid an egg");
        }
    }
}
