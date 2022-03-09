using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr=Eks(new int[] { -5, -40, 40, 35, 89, -98 });
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
                  
            static int[] Eks(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<0)
                {
                    arr[i]=arr[i]*(-1);
                }
               
            }
            return arr;
        }
        
    }
}


