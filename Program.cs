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
    }
}