using ConsoleApp6.ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
   public class MyClass
    {
        private int myVar;
        private int myVar2;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public int MyProperty2
        {
            get { return myVar2; }
            set { myVar2 = value; }
        }

        public MyClass(int myVar, int myVar2)
        {
            this.myVar = myVar;
            this.myVar2 = myVar2;
        }

        public void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }
        public void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }
        public void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
        public int print(int s, int s2)
        {
            Console.WriteLine("Printing string: {0}", s);
            return s2;
        }

    }

    static class StaticClass
    {
        public static int MyProperty { get; set; }
    }

   public class MyClass3
    {
        public static int x{ get; set; }
        public const int e=10;
        public readonly int s=10;
        protected int ProtectedField;
        public MyClass3(int x,int s)
        {
            this.s = s;
            MyClass3.x = x;
        }
        public MyClass3()
        {

        }
    }
    class MyClass11: MyClass3
    {

    }

    public class Solution
    {
        public static int MinStartValue(int[] nums)
        {
            int n = nums.Length;
            int s = 0;

            for (int i = 1; i < 100; i++)
            {
                int k = 0;
                int t = 0;
                for (int j = 0; j < n; j++)
                {
                    if (t == 0)
                    {
                        t = nums[j] + i;
                    }
                    else
                    {
                        t += nums[j];
                    }

                    if (t >= 1)
                    {
                        k++;
                        
                    }
                }
                if (k == n)
                {
                    s = i;
                    break;
                }
            }
            return s;
        }

        public void Show()
        {
            MinStartValue(new int[2] { 1, 2 });
        }

        public ListNode AddTwoNumbers(int[] l1, int[] l2)
        {
            int x = Int32.Parse(String.Join("", new List<int>(l1).ConvertAll(i => i.ToString()).ToArray()).Reverse().ToString());
            int y = Int32.Parse(String.Join("", new List<int>(l2).ConvertAll(i => i.ToString()).ToArray()).Reverse().ToString());
            int z = x + y;
            Console.WriteLine(z.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Reverse());
            Console.WriteLine(x);
            Console.WriteLine(y);
            return new ListNode();
        }
    }

    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
                 }
  }

    public class MyClass12
    {
        private int MyProperty1 { get; set; }
        protected int MyProperty2 { get; set; }
        internal int MyProperty3 { get; set; }
        internal protected int MyProperty4 { get; set; }
        private protected int MyProperty5 { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //int a = 0, b = 0, c;
            //c = ++a;
            //Console.WriteLine("", a, c);
            //Solution solution = new Solution();
            //int[] n = new int[5] { -3, 2, -3, 4, 2 };
            //int[] l1 = new int[3] { 2, 4, 3 };
            //int[] l2 = new int[3] { 5, 6, 4 };
            //Console.WriteLine(solution.MinStartValue(n));
            //solution.AddTwoNumbers(l1,l2);
            //MyClass3 myClass3 = new MyClass3(55,55);
            //Console.WriteLine($"static = {MyClass3.x}, const = {MyClass3.e},readonly = {myClass3.s},");

            //MyClass3.x = 100;
            //MyClass ex1 = new MyClass(1,2);
            //MyClass ex2 = ex1;

            //Console.WriteLine(ex1.GetHashCode());
            //Console.Write(ex2.GetHashCode());

            int i = 5;
            object o = i;
            long j = (int)o;
            Console.WriteLine(j);

            string y = "not null";
            string x = y ?? "null";
            Console.WriteLine(new string('-', 10));
            Console.WriteLine((2).ToString("C", new CultureInfo("en-US")));
            Console.WriteLine((2).ToString(""));
            Console.WriteLine(y ?? "null");

            int mySum = 0, mySum2 = 0, mySum3 = 0;
            for (int g = 1; g <= 10; g++)
                if (g % 2 == 0)
                    mySum += g;
                else if (g % 3 == 0)
                    mySum2 += g;
                else
                    mySum3 += g;
            Console.WriteLine($"{mySum},{mySum2},{mySum3}");

            Console.Title = "Мое приложение";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Привет, это мой проект!");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadLine();
            Program program = new Program();
            program.Show();


            MyObj<int> obj1 = new MyObj<int>(25);
            obj1.objectType();

            MyObjects<string, byte, decimal> obj2 = new MyObjects<string, byte, decimal>("Alex", 26, 12.333m);
            obj2.objectsType();

            bool? var = 6 > 4 || (5 < 7 && 4 >= 5) || !false;
            bool? var2 = (5 < 7 && 4 >= 5);
            bool? var3 = !false || false;
            
            Console.ReadLine();
            
            Console.ReadKey();
        }

        public static int MinStartValue(int[] nums)
        {
            int n = nums.Length;
            int s = 0;

            for (int i = 1; i < 100; i++)
            {
                int k = 0;
                int t = 0;
                for (int j = 0; j < n; j++)
                {
                    if (t == 0)
                    {
                        t = nums[j] + i;
                    }
                    else
                    {
                        t += nums[j];
                    }

                    if (t >= 1)
                    {
                        k++;

                    }
                }
                if (k == n)
                {
                    s = i;
                    break;
                }
            }
            return s;
        }
        #region
        public void Show()
        {
            Console.WriteLine(MinStartValue(new int[2] { 1, 2 }));
        }
        #endregion
    }

    namespace ConsoleApplication1
    {
        // Создадим обобщенный класс имеющий параметр типа T
        class MyObj<T>
        {
            T obj;

            public MyObj(T obj)
            {
                this.obj = obj;
            }

            public void objectType()
            {
                Console.WriteLine("Тип объекта: " + typeof(T));
            }
        }

        // Обобщенный класс с несколькими параметрами
        class MyObjects<T, V, E>
        {
            T obj1;
            V obj2;
            E obj3;

            public MyObjects(T obj1, V obj2, E obj3)
            {
                this.obj1 = obj1;
                this.obj2 = obj2;
                this.obj3 = obj3;
            }

            public void objectsType()
            {
                Console.WriteLine("\nТип объекта 1: " + typeof(T) +
                    "\nТип объекта 2: " + typeof(V) +
                    "\nТип объекта 3: " + typeof(E));
            }
        }
    }

}
