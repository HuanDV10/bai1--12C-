using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10_12
{
    internal class Animal
    {
        // phương thức ảo để lớp con ghi đè
        public virtual void makeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }
}
