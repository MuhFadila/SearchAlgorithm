﻿using System;

namespace SearchAlgorithm
{
    class Program
    {
        // array to be searched
        int[] arr = new int[20];
        // number of element in the array
        int n;
        // get the number of the element to store in the array
        int i;

        public void input()
        {
            while(true)
            {
                Console.Write("Enter the number of the elements in the array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\n array should have minimum 1 and maximum 20 elements.\n");
                
            }
            //accept array elements
            Console.WriteLine(" ");
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ ");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ ");
            for ( i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }

        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                //accept the number to be searched
                Console.Write("\nEnter element want you to search   : ");
                int item = Convert.ToInt32(Console.ReadLine());

                //apply binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //obtain the index of the element in the array
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //loop to search for the elements in the array
                while ((item != arr[mid]) && (lowerbound < -upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;

                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at position" + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "not found in the array\n");
                Console.WriteLine("\nNumber of comparison  : " + ctr);

                Console.Write("\nContinue search (y/n):");
                ch = char.Parse(Console.ReadLine());

            } while ((ch == 'y') || (ch == 'y'));
        }
    }
}
