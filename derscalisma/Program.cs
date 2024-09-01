using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace derscalisma
{
    class Program
    {
        static void Main(string[] args)
        { // Liste oluşturma ve eleman ekleme
            List<Animal> animalList = new List<Animal>();
            animalList.Add(new Dog());
            animalList.Add(new Cat());
            animalList.Add(new Dog());

            // Liste üzerinde işlem yapma
            foreach (var animal in animalList)
            {
                // Animal türünden bir nesne üzerinden Speak metodunu çağır
                animal.Speak();
            }
            Console.ReadKey();
        }
    }
}
