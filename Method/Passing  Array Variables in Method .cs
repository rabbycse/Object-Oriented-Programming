using System;
using System.Collections.Generic;
using System.Text;

namespace Method.Advance
{
    class Method
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5];

            arr[0] = "CSE";
            arr[1] = "SWE";
            arr[2] = "EEE";
            arr[3] = "CE";
            arr[4] = "IT";

            array_method(arr);

            Console.ReadLine();
        }

        public static void array_method(string[] name)
        {
            foreach (string variable in name)
            {
                Console.WriteLine(variable);
            }
        }

        
    }

}
