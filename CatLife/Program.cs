using CatLife.Model;

namespace CatLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat margit = new Cat();
            margit.Name = "Margit";
            margit.Weight = 4.5;
            margit.Hungry = true;

            Cat pamacs = new Cat("Pamacs", 6.8, false);
            Cat cirmi = new Cat("Cirmi", 2.7);

            Console.WriteLine("Kiindulási állapot: ");
            Console.WriteLine(margit.ToString()); 
            Console.WriteLine(pamacs.ToString()); 
            Console.WriteLine(cirmi.ToString());

            margit.Eats(1.5);
            pamacs.Eats(1.5);
            cirmi.Eats(1.5);

            Console.WriteLine("Etetés után: ");
            Console.WriteLine(margit.ToString());
            Console.WriteLine(pamacs.ToString());
            Console.WriteLine(cirmi.ToString());

            margit.Runs();
            pamacs.Runs();
            cirmi.Runs();

            Console.WriteLine("Futás után: ");
            Console.WriteLine(margit.ToString());
            Console.WriteLine(pamacs.ToString());
            Console.WriteLine(cirmi.ToString());


        }
    }
}
