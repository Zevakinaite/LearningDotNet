using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // Create an array of string size 5. Fill array items with values
            string[] skaiciai = new string[5];
            skaiciai[0] = "one";
            skaiciai[1] = "two";
            skaiciai[2] = "three";
            skaiciai[3] = "four";
            skaiciai[4] = "five";

            //Print all words using loop.
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(skaiciai[i]);
            }




            // Create an int array size 20. Fill values from 0 till 20
            // Nuo 0 iki 20 turėtų array size būti 21 ???
            int a = 0;
            int[] arr;
            arr = new int[21];
            for (int i = 0; i < 21; i++)
            {
                arr[i] = a;
                a++;
            }

            // Print numbers backwards.
            for (int j = 20; j >= 0; j--)
            {
                Console.WriteLine(arr[j]);
            }
            

            Console.ReadLine();
        }
    }
}
