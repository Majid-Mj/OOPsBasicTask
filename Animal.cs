using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsBasicTask
{
    internal class Animal
    {
        public string name;
        public decimal age;

        public void Speak()
        {
            Console.WriteLine($"{name}-{age} yeaars Old");
        }
    }


    internal class Dog : Animal
    {
        public string breed;
    }

    internal class Cat : Animal
    {
        public  void meow()
        {
            Console.WriteLine("Meowwww..");
            Console.WriteLine("Hey i am Kitti");
        }
    }
}
