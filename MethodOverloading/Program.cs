using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
       // All five methods have the same name, but they are with different parameters and signatures.
        public void Test()
        {
            Console.WriteLine("First Method");
        }
        public void Test(int x)
        {
            Console.WriteLine("Second Method");
        }
        public void Test(string x)
        {
            Console.WriteLine("Third Method");
        }
        public void Test(int x, string y)
        {
            Console.WriteLine("Fourth Method");
        }
        public void Test(string y, int x)
        {
            Console.WriteLine("Fifth Method");
        }
        static void Main(string[] args)
        {
            // in order to call those above method you will have to first identify the class
            Program pro = new Program();
            pro.Test();
            pro.Test(10);
            pro.Test("Hey");
            pro.Test(12, "Hi");
            pro.Test("Hi", 14);


        }
    }
}
