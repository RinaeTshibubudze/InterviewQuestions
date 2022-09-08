using System;

namespace ConsoleApp1
{
    public class TestCode
    {
        //Q8
        public void Print(params int[] b)
        {
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }
        }

        //Q12
        public static String print()
        {
            return "Hi, I am a Tech-savvy!!";
        }
    }
}