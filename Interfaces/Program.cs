using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccount ian = new Premium();
            ian.yOB = 2000;

            System.Console.WriteLine(ian.ageCalc());
        }
    }

    interface IAccount
    {
        string name { get; set; }
        int yOB {get; set;}
        int accNo{get; set;}
        int ageCalc();

    }

    interface Itrial
    {
        string name { get; set; }
        int accNo{get; set;}

    }

    class Premium: IAccount , Itrial
    {
        public string name {get; set;}
        public int yOB {get; set;}
        public int accNo{get; set;}
        public int ageCalc()
        {
            int age =2019 - yOB;
            return age;
        }
    }

    class Free: IAccount
    {
        public string name {get; set;}
        public int yOB {get; set;}
        public int accNo{get; set;}
        public int ageCalc()
        {
            int age =2019 - yOB;
            return age;
        }
    }

}
