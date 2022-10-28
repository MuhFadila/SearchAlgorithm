using System;

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
                
                
            }
        }
    }
}
