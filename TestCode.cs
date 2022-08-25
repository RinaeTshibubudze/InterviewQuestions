using System;

namespace ConsoleApp1
{
    public class TestCode
    {
        //Q8
        public void print(params int[] b)
        {
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }
        }
    }
}