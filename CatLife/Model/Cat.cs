using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatLife.Model
{
    internal class Cat
    {
        //tulajdonsag - auto property
        public string Name { get; set; }
        
        public double Weight { get; set; }

        public bool Hungry { get; set; }

        //ures konsktruktor
        public Cat()
        {
        }

        //parameteres konstruktor
        public Cat(string name, double weight, bool hungry)
        {
            Name = name;
            Weight = weight;
            Hungry = hungry;
        }

        public Cat(string name, double weight)
        {
            Name = name;
            Weight = weight;
            Hungry = true;
        }

        public bool Eats(double food)
        {
            if (Hungry)
            {
                Weight += food;
                Hungry = false;
                return true;
            }

            return false;
        }

        public void Runs()
        {
            Weight -= 0.5;
            if (!Hungry)
            { Hungry  = true; }
        }

        public override string ToString()
        {
            string hunger = "";
            if (Hungry)
            {    hunger = "A macska éhes"; }
            else { hunger = "A macska nem éhes"; }

            return $"A macska neve: {Name}, súlya {Weight}, {hunger}";
        }
    }
}
