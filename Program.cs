using System;

namespace Vs_Codes
{
    class Program
    {
        
        static void Main(string[] args)
        {
           Person caroline = new Person();
           caroline.name="Caro";
           

           Console.WriteLine(caroline.YoB(19));
           System.Console.WriteLine(caroline.balance); 
           System.Console.WriteLine();

           if(caroline.minimumAge >= 18)
           {
               System.Console.WriteLine("You can attend the meeting");
           }
           else
           {
               System.Console.WriteLine("You are under-age!");
           }
        }
        
    }

    class Person
    {
        public int minimumAge;
        public string name;
        public double balance { get; set; }

        public Person()
        {
            minimumAge = 18;
        }
        public int YoB(int age)
        {
            int finalAge = 2019-age;
            return finalAge;
        }
    }

    class Child:Person
    {
        public Child()
        {
            minimumAge = 0;
            balance = 50;
        }

        class Toys
        {
            public Toys()
            {
                System.Console.WriteLine("No toys yet!");
            }
        }

    }
}
