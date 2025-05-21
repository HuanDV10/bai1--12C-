using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10_12
{
    //Lớp con Dog kế thừa Animal
    internal class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }
}
