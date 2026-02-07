using System;

namespace Myfirst
{
    class Emma
    {
        static void Main(string[] args)
        {
           //Taking user input
           //Console.WriteLine("What is your name?"); 
           //String name = Console.ReadLine();
           //Console.WriteLine("Hello "+name);

           //increament
           int name = 5;
           //name = name + 1;
           //name += 1;
           //name++;
           //Console.WriteLine(name);


           /*int age = 18;
           if (age >= 18)
            {
                Console.WriteLine("This is your age");
            }*/

            //methods
            Sing();
            Sing();
            Sing();


        }
        static void Sing()
        {
            Console.WriteLine("Happy birthday to you");
        }
    }
}