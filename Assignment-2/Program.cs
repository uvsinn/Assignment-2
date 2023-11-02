using System.Collections.Specialized;

namespace Assignment_2
{
    internal class Program
    {
        void sumandavg()
        {
            //-----1. Print sum and average of elements of an Array-----
            int[] arr = new int[] { 10, 20, 30, 40, 50 };

            int Total_sum = arr.Sum(x => x);
            Console.WriteLine("Total sum: "+Total_sum);
            Console.WriteLine("Average: " + Total_sum/arr.Length);
        }

        void sumofmatrix()
        {
            //-----2.WAP to display sum of 3 by 3 matrices-----

            int[,,] a = new int[,,] {
    {{3, 4, 2, 3}, {0, -3, 9, 11}, {23, 12, 23, 2}},
    {{13, 4, 56, 3}, {5, 9, 3, 5}, {3, 1, 4, 9}}};

            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(2); k++)
                    {
                        sum += a[i,j,k];
                    }
                   
                }
              
            }
            Console.WriteLine("Total sum: " + sum);
        }
        void findmax()
        {
            //-----3. WAP to find the maximum element of an integer Array-----
            int[] arr = new int[] { 10, 20, 30, 40, 50 };
            
            Console.WriteLine("Max element: "+ arr.Max());
        }
        void columnwisesum()
        {
            //-----4. WAP to print column wise sum of elements of 2 D Array-----
            int[,] arr = new int[,] { { 10, 20, 30, 40 }, { 50, 70, 70, 80 } };
            

            for(int i=0;i<arr.GetLength(1);i++)
            {
                int sum = 0;
                for(int j=0;j<arr.GetLength(0);j++)
                {
                    sum += arr[j,i];
                }
                Console.WriteLine($"Sum of {i} column: {sum}");
            }
        }
        void rowwisesum()
        {
            //-----5. WAP to print row wise sum of elements of 2 D Array-----
            int[,] arr = new int[,] { { 10, 20, 30, 40 }, { 50, 70, 70, 80 } };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i,j];
                }
                Console.WriteLine($"Sum of {i} row: {sum}");
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();    
            program.rowwisesum();
        }
    }
}