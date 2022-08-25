using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;


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



            //Q16

            //TestDelegate obj = new TestDelegate();
            //SampleDelegate delegateObj = new SampleDelegate(obj.CheckEven);
            //delegateObj += new SampleDelegate(obj.SquareNumber);
            //delegateObj(25);

            //public delegate void SampleDelegate(int num);
            //public class TestDelegate
            //{
            //    public void CheckEven(int num)
            //    {
            //        if (num % 2 == 0)
            //            Console.WriteLine("This number is an even number");
            //        else
            //            Console.WriteLine("This number is an odd number");
            //    }

            //    public void SquareNumber(int num)
            //    {
            //        Console.WriteLine("Square of this number is: {0}", num * num);
            //    }
            //}

            //@17

            //var arr = new List { 20, 40, 35, 85, 70 };
            //var collection = new Collection<>(arr);
            //arr.Add(60);
            //arr.Sort();
            //Console.WriteLine(String.Join(",", collection));




            //Q18

            //Nullable number = 0;
            //int num = 1;
            //Console.WriteLine(number.GetType() == num.GetType());


            //Q19

            //A str1;
            //string str = "Let's Learn CSharp";
            //str1 = sample.StringMarker;
            //str1(ref str);
            //Console.WriteLine(str);

            //delegate void A(ref string str);
            //public class sample
            //{
            //    public static void StringMarker(ref string a)
            //    {
            //        a = a.Substring(0, a.Length - 6);
            //    }
            //}


            //Q20

            //bool a = true;
            //bool b = false;
            //a ^= b;
            //Console.WriteLine(a);
            //Console.ReadLine();


            //Q21

            //bool a = true;
            //bool b = false;
            //a |= b;
            //Console.WriteLine(a);
            //Console.ReadLine();


            //Q22


            //classA a = new classC();
            //Console.WriteLine(a.Print());


            //public class classA
            //{
            //    public virtual string Print()
            //    {
            //        return "classA";
            //    }
            //}

            //public class classB : classA
            //{
            //    public override string Print()
            //    {
            //        return "classB";
            //    }
            //}

            //public class classC : classB
            //{
            //    public new string Print()
            //    {
            //        return "ClassC";
            //    }
            //}


            //Q23

            //try
            //{
            //    throw new NullReferenceException("C");
            //    Console.WriteLine("A");
            //}
            //catch (ArithmeticException e)
            //{
            //    Console.WriteLine("B");
            //}

            //Q24


            //sample s = new sample();
            //s.assign(1, 1);
            //Console.WriteLine(s.x + " " + s.y);


            //class sample
            //{
            //    public int x;
            //    private int y;
            //    public void assign(int a, int b)
            //    {
            //        x = a + 1;
            //        y = b;
            //    }
            //}

            //Q25

            //int n = 5;
            //int x = 4;
            //int z, c, k;
            //z = 3 * x * x + 2 * x + 4 / x + 8;
            //for (c = 1; c <= n; c++)
            //{
            //    for (k = 1; k <= c; k++)
            //    {
            //        Console.Write(Convert.ToString(Convert.ToChar(z)));
            //        z++;
            //    }
            //    Console.WriteLine("\n");
            //}

            //Q26

            //int i, j = 1, k;
            //for (i = 0; i < 5; i++)
            //{
            //    k = j++  + ++j;
            //    Console.Write(k + " ");
            //}

            //Q27

            //Sample s = new Sample();
            //s.num = 100;
            //Sample.assign(0, 10);
            //s.assign(0, 9);
            //Console.WriteLine(s.arr[0]);

            //class Sample
            //{
            //    public int num;
            //    public int[] arr = new int[10];

            //    public void assign(int i, int val)
            //    {
            //        arr[i] = val;
            //    }
            //}

            //Q28

            //String s1 = "TechBeamers";
            //String s2 = "Welcomes its readers";
            //String s3 = s2;
            //Console.WriteLine((s3 == s2) + " " + s2.Equals(s3));

            //Console.ReadLine();int[] arr = { 1, 2, 3 };

            //Console.ReadLine();


            //Q29

            //string str = "100p";
            //int i = 0;
            //if (int.TryParse(str, out i))
            //{
            //    Console.WriteLine("Yes string contains Integer and it is " + i);
            //}
            //else
            //{
            //    Console.WriteLine("string does not contain Integer");
            //}


            //Q30

            //int[] arr = { 1, 2, 3 };
            //int i = 1;
            //arr[i++] = arr[i] + 10;
            //Console.WriteLine(String.Join(",", arr));


            //Q31

            //(i++).Assign();

            //public static int i = 0;
            //static class Extensions
            //    {
            //        public static void Assign(this int i)
            //        {
            //            Console.WriteLine(Program.i);
            //            Console.WriteLine(i);
            //        }
            //    }

            //Q32

            //Console.WriteLine((int)Color.green + ", ");
            //Console.WriteLine((int)Color.yellow);


            //enum Color : int
            //{
            //    red, green, blue = 5, cyan, magenta = 10, yellow
            //}

            //Q33

            //int i = 3;
            //int j = 2;
            //func1(ref i);
            //func2(out j);
            //Console.WriteLine(i + " " + j);

            //static void func1(ref int num)
            //{
            //    num = num + num;
            //}
            //static void func2(out int num)
            //{
            //    num = num * num;
            //}


            //Q34

            //var test = SingletonB.Test;

            //class SingletonB
            //{
            //            static readonly SingletonB _instance = new SingletonB();

            //    public static SingletonB Test { get { return _instance; } }

            //    private SingletonB()
            //    {
            //        Console.WriteLine("Default Constructor");
            //    }

            //    static SingletonB()
            //    {
            //        Console.WriteLine("Static Constructor");
            //    }
            //}

            //Q35

            //try
            //{
            //    Console.WriteLine("TechBeamers Welcomes Its Readers");
            //    Console.ReadLine();
            //    Environment.Exit(0);

            //}
            //finally
            //{
            //    Console.WriteLine("To the World of C# !!");
            //}

            //Q36

            //Calculation c = new Calculation();
            //try
            //{
            //    c.CalAverage();
            //}
            //catch (CountIsZeroException e)
            //{
            //    Console.WriteLine("CountIsZeroException : {0}", e);
            //}


            //public class Calculation
            //{
            //    int sum = 0;
            //    int count = 0;
            //    float average;
            //    public void CalAverage()
            //    {
            //        if (count == 0)
            //            throw (new CountIsZeroException("Zero count in DoAverage"));
            //        {
            //            average = sum / count;

            //            Console.WriteLine("Program executed successfully");
            //        }
            //    }
            //}
            //public class CountIsZeroException : ApplicationException
            //{
            //    public CountIsZeroException(string message) : base(message)
            //    {
            //    }
            //}

            //Q37

            //Derived d = new Derived();
            //int i = 10;
            //d.Func(i);
            //Console.ReadKey();

            //public class Base
            //{
            //    public virtual void Func(int x)
            //    {
            //        Console.WriteLine("Base.Func(int)");
            //    }
            //}
            //public class Derived : Base
            //{
            //    public override void Func(int x)
            //    {
            //        Console.WriteLine("Derived.Func(int)");
            //    }
            //    public void Func(object o)
            //    {
            //        Console.WriteLine("Derived.Func(object)");
            //    }
            //}

            //Q38

            //string str1 = "TechBeamers";
            //string str2 = "Techbeamers";
            //if (str1 == str2)
            //    Console.WriteLine("Both Strings are Equal");
            //else
            //    Console.WriteLine("Both Strings are Unequal");
            //if (str1.Equals(str2))
            //    Console.WriteLine("Both Strings are Equal");
            //else
            //    Console.WriteLine("Both Strings are Unequal");
            //Console.ReadLine();


            //Q39

            //    Sample s = new Sample();
            //    s.Print();

            //    ISample i = s;
            //    i.Print();

            //    public interface ISample
            //{
            //    void Print(string val = "Interface Executed");
            //}

            //public class Sample : ISample
            //{
            //    public void Print(string val = "Class Executed")
            //    {
            //        Console.WriteLine(val);
            //    }
            //}

            //Q40

            //int num = 0;
            //(num++);
            //Console.WriteLine(num);

            //Q41

            //int val = (byte)+(char)-(int)+(long)-2;
            //Console.WriteLine(val);

            //Q42

            //Boolean b1 = true, b2 = false;
            //if ((b2 = true) | (b1 ^ b2))
            //{
            //    Console.WriteLine("execution success");
            //}
            //else
            //{
            //    Console.WriteLine("execution failure");
            //}

            //Q43

            //string str1 = "\U0010FADE";
            //string str2 = "\U0000FADE";
            //Console.WriteLine(str1.Length);
            //Console.WriteLine(str2.Length);

            //Q44

            //int[] singleDimArray = { 1, 2, 3, 4 };
            //int[,] multiDimArray = { { 1, 2 }, { 3, 4 } };
            //int[][] jaggedArray = { new int[] { 1, 2 }, new int[] { 3, 4 } };

            //Console.WriteLine(singleDimArray.Length);
            //Console.WriteLine(multiDimArray.Length);
            //Console.WriteLine(jaggedArray.Length);

            //Q45

            //float num = 56, div = 0;

            //try
            //{
            //    Console.WriteLine(num / div);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Division By Zero");
            //}

            //Q46

            //for (int x = 0; x < 10; x++)
            //{
            //    Console.WriteLine(x + ' ');
            //}

            //Q47

            //double num1 = 1.000001;
            //double num2 = 0.000001;
            //Console.WriteLine((num1 - num2) == 1.0);

            //Q48
            //new Program(null);

            //public Program(Object o)
            //{
            //    Console.WriteLine("Object argument");
            //}
            //public Program(double[] arr)
            //{
            //    Console.WriteLine("double array argument");
            //}

            //Q49
            //Console.WriteLine("H" + 'I');
            //Console.WriteLine('h' + 'i');


            //Q50

            //String str = "";

            //StringBuilder sb1 = new StringBuilder("TechBeamers");
            //StringBuilder sb2 = new StringBuilder("TechBeamers");
            //StringBuilder sb3 = new StringBuilder("Welcome");
            //StringBuilder sb4 = sb3;

            //if (sb1.Equals(sb2)) str += "1";
            //if (sb2.Equals(sb3)) str += "2";
            //if (sb3.Equals(sb4)) str += "3";


            //String str1 = "TechBeamers";
            //String str2 = "Welcome";
            //String str3 = str2;

            //if (str1.Equals(str2)) str += "4";
            //if (str2.Equals(str3)) str += "5";
            //Console.WriteLine(str);

            //Q51

            //int i = 0, j = 0;

            //label:
            //i++;
            //j += i;
            //if (i < 10)
            //{
            //    Console.Write(i + " ");
            //    goto label;
            //}

            //Q52

            //int i = 20;
            //for (; ; )
            //{
            //    Console.Write(i + " ");
            //    if (i >= -10)
            //        i -= 4;
            //    else
            //        break;
            //}

            //Q53

            //    day obj = day.Wed;
            //    switch (obj)
            //    {
            //        case day.Sun:
            //            Console.WriteLine(day.Sun);
            //            break;

            //        case day.Mon:
            //            Console.WriteLine(day.Mon);
            //            break;

            //        case day.Tue:
            //            Console.WriteLine(day.Tue);
            //            break;

            //        case day.Wed:
            //            Console.WriteLine(day.Wed);
            //            break;

            //        case day.Thur:
            //            Console.WriteLine(day.Thur);
            //            break;

            //        case day.Fri:
            //            Console.WriteLine(day.Fri);
            //            break;

            //        case day.Sat:
            //            Console.WriteLine(day.Sat);
            //            break;



            //    }

            //public enum day
            //{ Sun, Mon, Tue, Wed, Thur, Fri, Sat };

            //Q54

            //int num;
            //for (num = -5; num <= 5; num++)
            //{
            //    switch (num)
            //    {
            //        case 0:
            //            Console.Write("Tech Beamers");
            //            break;
            //    }

            //    if (num > 0)
            //        Console.Write("+");
            //    else if (num < 0)
            //        Console.Write("*");
            //}


            //Q55

            //char ch = Convert.ToChar('c' | 'a'| 'b');
            //switch (ch)
            //{
            //    case 'A':
            //    case 'a':
            //        Console.WriteLine("case A | case a");
            //        break;

            //    case 'B':
            //    case 'b':
            //        Console.WriteLine("case B | case b");
            //        break;

            //    case 'C':
            //    case 'c':
            //    case 'D':
            //    case 'd':
            //        Console.WriteLine("case D | case d");
            //        break;
            //}

            //Q56

            //int a = 2, b = a;
            //if (Convert.ToBoolean((a | b & 5) & (b - 25 * 1)))
            //    Console.WriteLine(1);
            //else
            //    Console.WriteLine(0);

            //Q57

            //int id;
            //String val;
            //switch (id)
            //{
            //    case 5:
            //        val = "First";
            //        break;

            //    case 6:
            //        val = "Second";
            //        break;

            //    case 1:
            //        val = "Third";
            //        break;

            //    case ls < 4:
            //        val = "Fourth";
            //        break;

            //    case Else:
            //        val = "Fifth";
            //        break;
            //}

            //Q58

            //char Obj = 'L';
            //char Num = Convert.ToChar(76);
            //Obj--;
            //Num++;
            //Console.WriteLine(Obj + "  " + Num);
            //Console.ReadLine();

            //Q59

            //string[] strArr = { "Hello", "World" };
            //IList<string> strList = strArr;
            //IList<object> objList = strArr;
            //Console.Write(strList[0] + strList[1] + objList[1]);

            //Q60

            //int[] arr = { 1, 2, 3 };
            //display(arr);
            //display(4, 5, 6);

            // static void display(params int[] arr)
            // {
            //     foreach (var i in arr)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }

            //Q61
            //int[][][] arr = new int[2][][]
            //{
            //    new int[2][]
            //    {
            //        new int[3] {1, 2,3},
            //        new int[2] {4, 5 }
            //    },
            //    new int[1][]
            //    {
            //        new int[3] {7, 8, 9}

            //    }
            //};

            //Console.WriteLine(arr[1][0][1]);

            //Q62

            //DataStore<string> cities = new DataStore<string>();
            //cities.AddOrUpdate(0, "Mumbai");
            //cities.AddOrUpdate(1, "Chicago");
            //cities.AddOrUpdate(2, "London");

            //Console.WriteLine(cities.GetData(1));

            //DataStore<int> empIds = new DataStore<int>();
            //empIds.AddOrUpdate(0, 50);
            //empIds.AddOrUpdate(1, 65);
            //empIds.AddOrUpdate(2, 89);

            //Console.WriteLine(empIds.GetData(1));

            //class DataStore<T>
            //{
            //    private T[] _data = new T[10];

            //    public void AddOrUpdate(int index, T item)
            //    {
            //        if (index >= 0 && index < 10)
            //            _data[index] = item;
            //    }

            //    public T GetData(int index)
            //    {
            //        if (index >= 0 && index < 10)
            //            return _data[index];
            //        else
            //            return default(T);
            //    }
            //}

            Console.ReadLine();

        }

    }
   
}
