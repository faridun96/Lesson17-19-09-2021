using System;

namespace ArrayHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "a", "b", "c", "d", "e", "f" };
            Console.WriteLine("Исходный массив:");
            foreach (string s in arr) { Console.Write(s + " "); }
            Console.WriteLine("\nПоследний элемент массива, используем метод Pop: {0}", ArrayHelper.Pop(ref arr));
            Console.WriteLine("Новый массив:");
            foreach (string s in arr) { Console.Write(s + " "); }
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("\nИсходный массив:");
            foreach (int s in array) { Console.Write(s + " "); }
            Console.Write("\nДобавить новый элемент(типа int): ");
            int ne = int.Parse(Console.ReadLine());
            Console.WriteLine("Новая длина массива, используем метод Push: {0}", ArrayHelper.Push(ref array, ne));
            Console.WriteLine("Новый массив:");
            foreach (int s in array) { Console.Write(s + " "); }
            double[] arra = new double[] { 1.2, 2.3, 3.4, 4.5, 5.6, 6.7 };
            Console.WriteLine("\nИсходный массив:");
            foreach (double s in arra) { Console.Write(s + " "); }
            Console.WriteLine("\nПервый элемент массива, используем метод Shift : {0}", ArrayHelper.Shift(ref arra));
            Console.WriteLine("Новый массив:");
            foreach (double s in arra) { Console.Write(s + " "); }
            decimal[] ar = new decimal[] { 1.111m, 2.222m, 3.333m, 4.444m, 5.555m, 6.666m };
            Console.WriteLine("\nИсходный массив:");
            foreach (decimal s in ar) { Console.Write(s + " "); }
            Console.Write("\nДобавить элемент(типа decimal): ");
            decimal nw = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Новая длина массива, используем метод UnShift: {0}", ArrayHelper.UnShift(ref ar, nw));
            Console.WriteLine("Новый массив:");
            foreach (decimal s in ar) { Console.Write(s + " "); }
            Console.WriteLine();
            int[] arryaa = { 1, 4, 9, 0 };
            int[] newArr = ArrayHelper.Slice(arryaa, -1, -2);
            Console.WriteLine("Исходный массив:");
            foreach (var s in arryaa) 
            { 
                Console.Write(s + " "); 
            }
            Console.WriteLine();
            Console.WriteLine("Новый массив, используем метод Slice:");
            foreach (var item in newArr) 
            { 
                Console.Write($"{item} "); 
            }
        }
    }
    public static class ArrayHelper
    {
        public static T Pop<T>(ref T[] arr)
        {
            T LastElement = arr[^1];
            T[] newArray = new T[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
            return LastElement;
        }

        public static int Push<T>(ref T[] arr, T el)
        {
            T[] newArray = new T[arr.Length + 1];
            newArray[arr.Length] = el;
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
            return arr.Length;
        }

        public static T Shift<T>(ref T[] arr)
        {
            T FirstElement = arr[0];
            T[] newArray = new T[arr.Length - 1];
            for (int i = 1; i < arr.Length; i++)
            {
                newArray[i - 1] = arr[i];
            }
            arr = newArray;
            return FirstElement;
        }

        public static int UnShift<T>(ref T[] arr, T el)
        {
            T[] newArray = new T[arr.Length + 1];
            newArray[0] = el;
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i + 1] = arr[i];
            }
            arr = newArray;
            return arr.Length;
        }

        public static T[] Slice<T>(T[] newArr, int beginIndex = 0, int endIndex = 0)
        {
            T[] arr = new T[newArr.Length];

            if (beginIndex > newArr.Length)
            {
                return arr;
            }
            if (endIndex == 0)
            {
                endIndex = newArr.Length;
            }
            if (beginIndex >= 0)
            {
                if (endIndex >= 0)
                {
                    for (int i = beginIndex; i < endIndex; i++)
                    {
                        int j = 0;
                        arr[j] = newArr[i];
                        j++;
                    }
                }
                else if (endIndex < 0)
                {
                    for (int i = beginIndex; i < newArr.Length + endIndex; i++)
                    {
                        int j = 0;
                        arr[j] = newArr[i];
                        j++;
                    }
                }
            }
            if (beginIndex < 0)
            {
                if (endIndex >= 0)
                {
                    for (int i = newArr.Length - 1; i >= newArr.Length + beginIndex; i--)
                    {
                        int j = 0;
                        arr[j] = newArr[i];
                        j++;
                    }
                }
                else if (endIndex <= 0)
                {
                    for (int i = newArr.Length - 1 + endIndex; i > beginIndex + newArr.Length - 1 + endIndex; i--)
                    {
                        int j = 0;
                        arr[j] = newArr[i];
                        j++;
                    }
                }
            }
            return arr;
        }
    }
}
