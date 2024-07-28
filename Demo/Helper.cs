using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Helper<T>where T : class, IComparable<T> 
    {
        //T must be class or struct and implementing the interface Icomparable
        #region Primary Constrain
        //1-General Primary [0-1]
        //class => T must be class 
        //struct => T must be struct 
        //not null => T must be nit nullable C#8 
        //Enum => T must be Enum  C#7
        //2-Special primary constrain ((user defined class) expect sealed class)


        #endregion
        #region Secondary constrain
        //Interface constrain [0-M]
        //Icomparable<T>
       // T must be class / struct Implementing Icomparable
        #endregion
        #region Constructor Constraint
        //parameterless constructor constraint [0-1]
        //must be data type having accessable[non - private ]parameterless constructor 
        //
        //
        #endregion
        #region Before Genarics
        //public static void Swap(ref object x, ref object y)
        //{
        //    Console.WriteLine("After Swap");
        //    object Temp = x;
        //    x = y;
        //    y = Temp;
        //}
        //public static void Swap(ref double x, ref double y)
        //{
        //    Console.WriteLine("After Swap");
        //    double Temp = x;
        //    x = y;
        //    y = Temp;
        //}
        //public static void Swap(ref Point p1, ref Point p2)
        //{
        //    Console.WriteLine("After Swap");
        //    Point Temp = p1;
        //    p1 = p2;
        //    p2 = Temp;
        //}
        #endregion
        #region After Generics
        //Compiler Can Detect The Type Of "T" Based On
        //The Type Of "Method Input Parameters" 
        //In Case Generic Type T Is Declared On Method Level
        //Not {Class - Struct Interface}
        public static void SWAP(ref T x, ref T y)
        {
            Console.WriteLine("After Swap");
            T Temp = x;
            x = y;
            y = Temp;
        }
        //public static int SearchArray(T[]arr,T Value)
        //{
        //    if (arr is not null && Value is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (Value.Equals(arr[i]))
        //                return i;
        //        }
        //    }
        //    return -1;
        //}
        //--------------------------------
        public static void BubbleSort(T[] arr)
        {
            if (arr is not null)
            { 
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length-i-1; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1])==1)
                           Helper<T>.SWAP(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        #endregion{

    }
}
