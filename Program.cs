using OOPsBasicTask;
using System;

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.name = "Jimmii";
        myDog.age = 2;
        myDog.breed = "fris";
        myDog.Speak();


        Cat myCat = new Cat();
        myCat.name = "kiyiyi";
        myCat.age = 1;
        myCat.meow();
        myCat.Speak();




    }
}