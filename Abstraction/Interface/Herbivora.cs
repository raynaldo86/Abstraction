using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Herbivora : IAnimal
    {
        public void Makanan()
        {
            Console.WriteLine("Hewan herbivora adalah kelompok hewan pemakan tumbuhan.");
            Console.WriteLine("Pada umunya hewan ini tidak memiliki gigi taring yang tajam.");
        }
    }
}
