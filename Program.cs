 using System;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4 };
            System.Console.WriteLine("Создание Листа");
            foreach (var z in x)
            {
                System.Console.WriteLine(z);
            }
            System.Console.WriteLine("Лист после использование");
            int end = akmal.Pop(ref x);
            foreach (var z in x)
            {
                System.Console.WriteLine(z);
            }
            System.Console.WriteLine($"Удалить {end}");
            System.Console.WriteLine("Лист после медота Push");
            akmal.Push(ref x, 6);
            foreach (var z in x)
            {
                System.Console.WriteLine(z);
            }
            System.Console.WriteLine("Лист полсе метода Shift");
            int fs = akmal.Shift(ref x);
            foreach (var z in x)
            {
                System.Console.WriteLine(z);
            }
            System.Console.WriteLine($"Удалить {fs}");
            System.Console.WriteLine("Лист после метода UnShift");
            akmal.UnShift(ref x, 8);
            foreach (var z in x)
            {
                System.Console.WriteLine(z);
            }
            Console.ReadKey();
        }
    }
    class akmal
    {

        public static string Pop(ref string[] arr)

        {
            string[] aki = new string[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                aki[i] = arr[i];
            }
            string end = arr[arr.Length - 1];
            arr = aki;
            return end;
        }
        public static double Pop(ref double[] arr)
        {
            double[] aki = new double[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                aki[i] = arr[i];
            }
            double end = arr[arr.Length - 1];
            arr = aki;
            return end;
        }
        public static int Pop(ref int[] arr)
        {
            int[] aki = new int[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                aki[i] = arr[i];
            }
            int end = arr[arr.Length - 1];
            arr = aki;
            return end;
        }
        public static decimal Pop(ref decimal[] arr)
        {
            decimal[] aki = new decimal[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                aki[i] = arr[i];
            }
            decimal end = arr[arr.Length - 1];
            arr = aki;
            return end;
        }
        public static void Push(ref string[] arr, string ne)
        {
            string[] aki = new string[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                aki[i] = arr[i];
            }
            aki[aki.Length - 1] = ne;
            arr = aki;
        }
        public static void Push(ref double[] arr, double ne)
        {
            double[] aki = new double[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                aki[i] = arr[i];
            }
            aki[aki.Length - 1] = ne;
            arr = aki;
        }
        public static void Push(ref int[] arr, int ne)
        {
            int[] aki = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                aki[i] = arr[i];
            }
            aki[aki.Length - 1] = ne;
            arr = aki;
        }
        public static void Push(ref decimal[] arr, decimal ne)
        {
            decimal[] aki = new decimal[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                aki[i] = arr[i];
            }
            aki[aki.Length - 1] = ne;
            arr = aki;
        }
        public static string Shift(ref string[] arr)
        {
            string[] aki = new string[arr.Length - 1];
            for (int i = 0; i < aki.Length; i++)
            {
                aki[i] = arr[i + 1];
            }
            string fs = arr[0];
            arr = aki;
            return fs;
        }
        public static double Shift(ref double[] arr)
        {
            double[] aki = new double[arr.Length - 1];
            for (int i = 0; i < aki.Length; i++)
            {
                aki[i] = arr[i + 1];
            }
            double fs = arr[0];
            arr = aki;
            return fs;
        }
        public static int Shift(ref int[] arr)
        {
            int[] aki = new int[arr.Length - 1];
            for (int i = 0; i < aki.Length; i++)
            {
                aki[i] = arr[i + 1];
            }
            int fs = arr[0];
            arr = aki;
            return fs;
        }
        public static decimal Shift(ref decimal[] arr)
        {
            decimal[] aki = new decimal[arr.Length - 1];
            for (int i = 0; i < aki.Length; i++)
            {
                aki[i] = arr[i + 1];
            }
            decimal fs = arr[0];
            arr = aki;
            return fs;
        }
        public static void UnShift(ref string[] arr, string ne)
        {
            string[] aki = new string[arr.Length + 1];
            aki[0] = ne;
            for (int i = 0; i < aki.Length - 1; i++)
            {
                aki[i + 1] = arr[i];
            }


            arr = aki;
        }
        public static void UnShift(ref double[] arr, double ne)
        {
            double[] aki = new double[arr.Length + 1];
            aki[0] = ne;
            for (int i = 0; i < aki.Length - 1; i++)
            {
                aki[i + 1] = arr[i];
            }
            arr = aki;
        }
        public static void UnShift(ref int[] arr, int ne)
        {
            int[] aki = new int[arr.Length + 1];
            aki[0] = ne;
            for (int i = 0; i < aki.Length - 1; i++)
            {
                aki[i + 1] = arr[i];
            }
            arr = aki;
        }
        public static void UnShift(ref decimal[] arr, decimal ne)
        {
            decimal[] aki = new decimal[arr.Length + 1];
            aki[0] = ne;
            for (int i = 0; i < aki.Length - 1; i++)
            {
                aki[i + 1] = arr[i];
            }
            arr = aki;
        }
    }
}