using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter11Ex01
{
    public abstract class Animal
    {
        protected string name;
        public  string Name { get => name; set => name = value; }
    
        public Animal()
    {
        name = "The animal with no name";
    }
    
        public Animal(string newName)
        {
            this.name = newName;
        }
        
        public class Cow : Animal
        {
            public void Milk()
            {
                Console.WriteLine($"{name} has been milked .");
            }

            public Cow(string newName) : base(newName)
            {
                Console.WriteLine($"{newName}");
            }
        }

    }
}

