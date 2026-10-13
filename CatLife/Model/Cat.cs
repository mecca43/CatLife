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
        private string _name;

        private double _weight;

        public bool Hungry { get; set; }
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A macskának kell hogy legyen neve");
                _name = value.Trim();
                _name = char.ToUpper(_name[0]) + _name.Substring(1);
            }
        }

        public double Weight {
            get => _weight;
            set { 
                if (value < 1)
                    _weight = 1;
                else if (value > 12)
                    _weight = 12;
                else
                    _weight = value;
            }
            }

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
