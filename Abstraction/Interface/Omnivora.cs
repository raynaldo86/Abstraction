using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Omnivora : IAnimal
    {
        public void Makanan()
        {
            Console.WriteLine("Hewan omnivora adalah kelompok hewan pemakan segalanya meliputi tumbuhan maupun daging.");
            Console.WriteLine("Memiliki gigi yang tajam pada bagian depan, berfungsi untuk mengoyak daging, dan gigi yang datar pada bagian belakang, berfungsi untuk menghaluskan makanan, yaitu baik tumbuhan maupun daging.");
        }
    }
}
