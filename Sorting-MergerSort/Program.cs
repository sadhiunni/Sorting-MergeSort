using System;
/*
 *Implementing the Merge Sort Algorithm
 *The array will be inputted by the user
 *Merge sort - keeps on diving the list into two havles recursively until it can not be divided anymore(reaches single element arrays).The n it  will be merged back into a single sorted array.
*/
namespace Sorting_MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merge Sort");
            Console.WriteLine("_______________________________________________");
            
            int[] ArrA = InputArray();

            Console.WriteLine("\nOriginal Array : ");
            foreach (var element in ArrA)
            {
                Console.Write(element+" ");
            }
            MergeSort(ArrA);
            Console.WriteLine("\n\nArray is sorted using Merge Sort");
            Console.WriteLine("\nSorted array : ");
            foreach (var item in ArrA)
            {
                Console.Write(item+ " " );
            }
            Console.WriteLine("\n");
            Console.WriteLine("_______________________________________________");
        }
        //input elements
        public static int[] InputArray() 
        {
            int no;
            Console.WriteLine("Please enter the number of elements in the array");
            no = Convert.ToInt32(Console.ReadLine());
            int[] ArrA = new int[no];
            Console.WriteLine("Please enter array elements");
            Console.WriteLine("Note : press enter, after entering each element");
            for (int i = 0; i <= no-1;i++) 
            {
                ArrA[i] = Convert.ToInt32(Console.ReadLine());
            }
            return ArrA;
        }
        //mergesort
        public static int[] MergeSort(int[] A) 
        {
            int mid;
            int[] result = new int[A.Length];
            if (A.Length < 2)
                return A;
            mid = A.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[A.Length - mid];

            for (int i = 0; i <= mid - 1; i++) 
            {
                left[i] = A[i];
            }
            for (int i =mid ; i <= (A.Length-1) ; i++) 
            {
                right[i-mid] = A[i];
            }
            left =MergeSort(left);
            right = MergeSort(right);
            result = Merge(left, right, A);
            return result;
;        }
        //merge
        public static int[] Merge(int[] left,int[] right, int[] A) 
        {
            int nL, nR , i ,j , k;
            nL = left.Length;
            nR = right.Length;
            i = j = k = 0;
            while (i < nL && j < nR) 
            {
                if (left[i] <= right[j])
                {
                    A[k] = left[i];
                    i++;
                    k++;
                }
                else
                {
                    A[k] = right[j];
                    j++;
                    k++;
                }
            }
            while (i < nL) 
            {
                A[k] = left[i];
                i++;
                k++;
            }
            while (j < nR)
            {
                A[k] = right[j];
                j++;
                k++;
            }
            return A;
        }
    }
}
