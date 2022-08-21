using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1
            //Console.WriteLine(Math.Round(2.5));
            //Console.WriteLine(Math.Round(7.5));


            //Q2 
            //int[] i = new int[0];
            //Console.WriteLine(i[0]);



            //Q3

            //byte num = 100;
            //dynamic val = num;
            //Console.WriteLine(val.GetType());
            //val += 100;
            //Console.WriteLine(val.GetType());


            //Q4

            //#if (!pi)
            //Console.WriteLine("i");
            //#else
            // Console.WriteLine("PI undefined");
            //#endif
            //Console.WriteLine("ok");

            //Q5

            //int[] arr = new int[2];
            //arr[1] = 10;
            //Object o = arr;
            //int[] arr1 = (int[])o;
            //arr1[1] = 100;
            //Console.WriteLine(arr[1]);
            //((int[])o)[1] = 1000;
            //Console.WriteLine(arr[1]);

            //Q6

            //String a = "TechBeamers";
            //String b = "TECHBEAMERS";
            //int c;
            //c = a.CompareTo(b);
            //Console.WriteLine(c);

            //Q7

            //int[] arr = new int[10];
            //arrayMethod(arr);
            //Console.WriteLine(arr.Length);

            //void arrayMethod(int[] a)
            //{
            //    int[] b = new int[5];
            //    a = b;
            //}

            //Q8

            //Program p = new Program();
            //p.print(2, 3, 8);
            //int[] arr = { 2, 11, 15, 20 };
            //p.print(arr);
            //Console.ReadLine();

            //public void print(params int[] b)
            //{
            //    foreach (int i in b)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //Q9

            //char x = 'A';
            //int i = 0;
            //Console.WriteLine(true ? x : 0);
            //Console.WriteLine(false ? i : x);

            //Q10

            //int num1 = 20;
            //int num2 = 30;
            //num1 ^= num2 ^= num1 ^= num2;
            //Console.WriteLine(num1 + "," + num2);

            //Q11

            //char[] num = { '1', '2', '3' };
            //Console.WriteLine(" char array: " + num);


            //Q12

            //Program obj = null;
            //Console.WriteLine(Program.print());
            //Console.ReadLine();

            //private static String print()
            //{
            //    return "Hi, I am a Tech-savvy!!";
            //}

            //Q13

            //string[] strings = { "abc", "def", "ghi" };

            //var actions = new List();
            //foreach (string str in strings)
            //    actions.Add(() => { Console.WriteLine(str); });

            //foreach (var action in actions)
            //    action();


            //Q14

            //var actions = new List();
            //for (int i = 0; i < 4; i++) actions.Add(() => Console.WriteLine(i));
            //foreach (var action in actions)
            //    action();


            //Q15

            //   delegate string del(string str);
            //   class sample
            //   {
            //       public static string DelegateSample(string a)
            //       {
            //           return a.Replace(',', '*');
            //       }
            //   }

            //del str1 = new del(sample.DelegateSample);
            //string str = str1("Welcome,,friends,,to,,TechBeamers");
            //Console.WriteLine(str);

            Console.ReadLine();


        }

    }
}
