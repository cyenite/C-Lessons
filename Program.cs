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
               System.Console.WriteLine(Meetup.venue);
           }
           else
           {
               System.Console.WriteLine("You are under-age!");
           }
        }
        
    }

    class Person                        //Normal class
    {
        public int minimumAge;          //Field
        public string name;
        public double balance { get; set; }         //Property

        public Person()                             //Constructor
        {
            minimumAge = 18;
        }
        public int YoB(int age)                     //Method
        {
            int finalAge = 2019-age;
            return finalAge;
        }
    }

    class Child:Person                              //Inheritance
    {
        public Child()
        {
            minimumAge = 0;
            balance = 50;
        }
    }

    static class Meetup                             //static class
    {
        public static string venue = "Nairobi";
        public static int date;
    }
}
