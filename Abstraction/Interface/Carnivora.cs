using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Carnivora : IAnimal
    {
        public void Makanan()
        {
            Console.WriteLine("Hewan karnivora adalah kelompok hewan pemakan daging.");
            Console.WriteLine("Untuk bisa melakukan perburuan dan memakan daging, hewan ini memiliki gigi taring untuk merobek daging makanannya.");
        }
    }
}
