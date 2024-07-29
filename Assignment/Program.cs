using Assignment.Q2;
using Assignment.Q5;
using System.Collections;

namespace Assignment
{
    internal class Program
    {
        #region Q3 func
        public static void ReverseArrayList(ArrayList list)
        {
            if (list == null || list.Count <= 1)
            {
                return;
            }

            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {object temp = list[left]!;
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }
        #endregion
        #region Q4 func
        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            return evenNumbers;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q2
            //Range<int> intRange = new Range<int>(5, 15);
            //Console.WriteLine($"Is 10 in range: {intRange.IsInRange(10)}"); // Output: True
            //Console.WriteLine($"Is 20 in range: {intRange.IsInRange(20)}"); // Output: False
            //Console.WriteLine($"Length of range: {intRange.Length()}"); // Output: 10

            //Range<double> doubleRange = new Range<double>(3.5, 7.5);
            //Console.WriteLine($"Is 5.5 in range: {doubleRange.IsInRange(5.5)}"); // Output: True
            //Console.WriteLine($"Is 8.5 in range: {doubleRange.IsInRange(8.5)}"); // Output: False
            //Console.WriteLine($"Length of range: {doubleRange.Length()}"); // Output: 4.0

            #endregion
            #region Q3
            //ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Original ArrayList:");
            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}

            //ReverseArrayList(list);

            //Console.WriteLine("\nReversed ArrayList:");
            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion
            #region Q4
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> evenNumbers = GetEvenNumbers(numbers);

            //Console.WriteLine("Original list:");
            //foreach (var number in numbers)
            //{
            //    Console.Write(number + " ");
            //}

            //Console.WriteLine("\nEven numbers list:");
            //foreach (var number in evenNumbers)
            //{
            //    Console.Write(number + " ");
            //}
            #endregion
            #region Q5
            //FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(3);
            //fixedSizeList.Add(1);
            //fixedSizeList.Add(2);
            //fixedSizeList.Add(3);
            //fixedSizeList.Display();
            //fixedSizeList.Add(4);
            //Console.WriteLine(fixedSizeList.GetValue(0));
            //try
            //{
            //    fixedSizeList.Add(4);

            //}
            //catch (Exception e)
            //{ 
            //Console.WriteLine(e.Message);    
            //}
            #endregion
        }
    }
}
