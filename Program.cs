using System;

namespace binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int first = 0;
           
            int[] arr = new int[100];

            Console.WriteLine("Enter the limit of the array");
            int limit = Convert.ToInt16(Console.ReadLine());

            int last = limit - 1;

            Console.WriteLine("Enter "+ limit +" elements to the array");

            for (int i=0; i<limit; i++)
            {
                Console.WriteLine("Enter number for index " +i);
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Enter the search key");
            int key = Convert.ToInt32(Console.ReadLine());


            int result = binarySearch(key, arr, first, last);

            if(result == -1)
            {
                Console.WriteLine("Entered key is unable to find in the array");
            }
            else
            {
                Console.WriteLine("Entered key is found at the index of " + result);
            }
        }

        static int binarySearch(int key, int[] arr, int first, int last)
        {
            

            while(first <= last)
            {
                int mid = (first + last) / 2;

                if(arr[mid] == key)
                {
                    return mid;
                }
                else if(arr[mid] <= key)
                {
                    first = mid + 1;
                }
                else if (arr[mid] >= key)
                {
                    last = mid - 1;
                }
            }
            return -1;
        }
    }
}
