using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter11Ex01
{
    public class Cow:Animal
    {
        public void Milk()
        {
            Console.WriteLine($"{name} has been milked .");
        }

        public Cow(string newName) : base(newName)
        {
            Console.WriteLine("cow ");
        }
    }
}
