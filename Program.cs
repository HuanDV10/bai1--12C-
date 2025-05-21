using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("Dog:");
            Console.WriteLine("Dog1111:");
            dog.makeSound();

            Cat cat = new Cat();
            Console.WriteLine("Cat:");
            cat.makeSound();
        }
    }
}
