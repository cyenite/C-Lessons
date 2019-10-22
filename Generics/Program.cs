using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations<int> math = new Operations<int>();
            math.Assign(3);

            math.FindType();   
        }
    }
    class Operations<T>
    {
        private T name;

        public void Assign(T value){
           
           
            
        }
        public void FindType()
        {
            System.Console.WriteLine("Data type: {0}  Value: {1}",typeof(T).ToString(), name);
        }
    }
}
