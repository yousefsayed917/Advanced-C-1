namespace Demo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Befare Genarics
            //int a = 2; 
            //int  b = 4;
            //Console.WriteLine($"A={a}");
            //Console.WriteLine($"B={b}");
            //Helper.Swap(ref a, ref b);
            //Console.WriteLine($"A={a}");
            //Console.WriteLine($"B={b}");
            //----------------------------
            //double a = 2;
            //double b = 4;
            //Console.WriteLine($"A={a}");
            //Console.WriteLine($"B={b}");
            //Helper.Swap(ref a, ref b);
            //Console.WriteLine($"A={a}");
            //Console.WriteLine($"B={b}");
            //----------------------------
            //Point p1 = new Point(4, 3);
            //Point p2 = new Point(6, 5);
            //Console.WriteLine($"A={p1}");
            //Console.WriteLine($"B={p2}");
            //Helper.Swap(ref p1,ref p2);
            //Console.WriteLine($"A={p1}");
            //Console.WriteLine($"B={p2}");
            #endregion
            #region After Genarics
            #region Example Swap
            // using Generics Swap
            //int a = 2; 
            //int  b = 4;
            //Console.WriteLine($"A={a}");
            //Console.WriteLine($"B={b}");
            //Helper.Swap(ref a, ref b);
            //Console.WriteLine($"A={a}");
            //Console.WriteLine($"B={b}");
            //----------------------------
            //double a = 2;
            //double b = 4;
            //Console.WriteLine($"A={a}");
            //Console.WriteLine($"B={b}");
            //Helper.Swap(ref a, ref b);
            //Console.WriteLine($"A={a}");
            //Console.WriteLine($"B={b}");
            //----------------------------
            //Point p1 = new Point(4, 3);
            //Point p2 = new Point(6, 5);
            //Console.WriteLine($"A={p1}");
            //Console.WriteLine($"B={p2}");
            //Helper.Swap(ref p1,ref p2);
            //Console.WriteLine($"A={p1}");
            //Console.WriteLine($"B={p2}");
            #endregion
            #region Example Search
            //int[] Num = { 3, 5, 4, 9, 4, 1 };
            //Console.WriteLine(Helper<int>.SearchArray(Num, 9));
            //-----------------------------
            //Employee employee1 = new Employee(1, " yousef ", 20000);
            //Employee employee2 = new Employee(2, " mohamed" ,30000);
            //Employee[] employees = { employee1, employee2 };
            //Console.WriteLine(Helper<Employee>.SearchArray(employees, employee2));
            #endregion
            #region Example Pubble Sort
            //int[] Num = { 3, 5, 4, 9, 4, 1 };
            //Helper<int>.BubbleSort(Num);
            //foreach (var item in Num)
            //{
            //    Console.WriteLine(item);
            //}
            //------------------------------------
            //Employee employee1 = new Employee(1, " yousef ", 40000);
            //Employee employee2 = new Employee(2, " mohamed", 30000);
            //Employee[] employees = { employee1, employee2 };
            //Helper<Employee>.BubbleSort(employees);
            //foreach (Employee item in employees)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
        }
    }
}
