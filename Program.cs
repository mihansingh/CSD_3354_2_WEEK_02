using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mary = new newClass();
            Console.WriteLine(" how many objects : {0}", newClass.reportOnNumberofObjects());

            var paul = new newClass();
            Console.WriteLine(" how many objects : {0}", newClass.reportOnNumberofObjects());

            var peter = new newClass();
            peter.newmethod();
            Console.WriteLine(" how many objects : {0}", newClass.reportOnNumberofObjects());
            Console.ReadLine();

        }
        public class newClass
        {
            public static int howManyObjects = 0;
            public newClass()
            {
                howManyObjects++;
                Console.WriteLine("In the Constructor : Ahhaa!!");
                Console.ReadLine();
            }
            public void newmethod()
            {
                int i = 0;
                int Sum = 0;

                for (i = 819; i >= 205; i = i - 17)
                {
                    Sum = Sum + i;

                }
                {
                    Console.WriteLine(Sum);
                    Console.ReadLine();
                }

                public static int reportOnNumberofObjects()

                {
                    return howManyObjects;
                }
            }
        }
    }
}

