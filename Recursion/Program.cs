using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{

    internal class MyClass
    {

        internal void GetInteger(int n, int m)
        {
            int number = m;
            if (number == n)
                return;
            else
            {
                number--;
                Console.Write(number);
                GetInteger(n, number);
            }
            Console.WriteLine();
        }

        internal int AccermanFunc(int n, int m)
        {
            if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
            if (n == 0) return m + 1;
            if (m == 0) return AccermanFunc(n - 1, 1);
            return AccermanFunc(n - 1, AccermanFunc(n, m - 1));
        }

        internal void GetArr(int[] arr, int counter)
        {            
            if (counter == - 1)
                return;
            else
            {
                Console.Write(arr[counter]);
                counter--;
                GetArr(arr, counter);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[5];
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = rnd.Next(1, 5);
            }

            MyClass myClass = new MyClass();
            myClass.GetInteger(1, 5);
            int i = myClass.AccermanFunc(1, 2);
            Console.WriteLine(i);
            myClass.GetArr(arr, arr.Length - 1);
            Console.ReadKey();
        }
    }
}
