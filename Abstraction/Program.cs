using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Abstraction.AbstractClass;
using Abstraction.Interface;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstraction.AbstractClass;
            /*Animal animal;

            animal = new Herbivora();
            animal.Makanan();

            Console.WriteLine();
            animal = new Carnivora();
            animal.Makanan();

            Console.WriteLine();
            animal = new Omnivora();
            animal.Makanan();*/

            //Abstraction.Interface;
            IAnimal animal;

            animal = new Herbivora();
            animal.Makanan();

            Console.WriteLine();
            animal = new Carnivora();
            animal.Makanan();

            Console.WriteLine();
            animal = new Omnivora();
            animal.Makanan();

            Console.ReadKey();
        }
    }
}
