using System;

namespace ConsoleApp1HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //var t1 = 1;
            //string t = "1";
            //Console.WriteLine(t);
            //string t2 = t;
            ////bool t3 = Convert.ToBoolean(t.ToString());
            ////Console.WriteLine(t3);
            //Console.WriteLine(t1);
            ////bool t4 = Convert.ToBoolean(t.ToString());
            ////Console.WriteLine(t4);
            //Console.WriteLine(t);
            //Console.WriteLine("Hello World");
            //const float pi = 3.14f;
            //Console.WriteLine(pi);

            //bool b = true;
            //bool b2 = b;
            //Console.WriteLine(b);
            //Console.WriteLine(b2);
            //string b3 = Convert.ToString(b);
            //Console.WriteLine(b3);
            //Console.WriteLine(b);
            //Console.WriteLine(b2);

            checked
            {
                byte number1 = 250;     //if this exceeds the given types lenght gives exception with checked if not just give wrong value
                                            // without any error
                number1 = (byte)(number1 + 1);
                Console.WriteLine(number1);
            }

            var a1 = 1;
            var a2 = 2;
            var b1 = a1;
            var b2 = a2;

            Console.WriteLine(a1++ > a2 && b1++ == b2);
            Console.WriteLine("{0} {1} {2} {3}", a1, a2, b1, b2);

            var c1 = 1;
            var c2 = 2;
            var d1 = c1;
            var d2 = c2;

            Console.WriteLine(c1++ > c2 & d1++ == d2);
            Console.WriteLine("{0} {1} {2} {3}", c1, c2, d1, d2);

        }
    }
}
