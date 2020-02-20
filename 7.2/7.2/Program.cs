using System;
using System.IO;
namespace _7._2
{
    class Program
    {
        static void Main(string[] args)
        {             
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Выберите вид массива:\n1)Массив мз 100000 элементов, сгенерированный случайным образом\n2)Отсортированный массив из 100000 элементов по возрастанию\n3)Отсортированный массив из 100000 элементов по убыванию\n4)Закончить проверку");
                string answer = Console.ReadLine();
                CC();
                switch (answer)
                {
                    case "1":

                        int [] array=InitCasualArray();
                        Console.WriteLine("Выберите алгоритм сортировки:\n1)Сортировка выбором\n2)Сортировка вставками\n3)Пузырьковая сортировка\n4)Шейкерная сортировка\n5)Сортировка Шелла\n6)Выход");
                        string secondanswer = Console.ReadLine();
                        CC();
                        switch (secondanswer)
                        {
                            case "1":
                                TestSelectionSort(array, 0, 0);
                                Checker(array);
                                ToFile(array);
                                CR();
                                CC();
                                break;
                            case "2":
                                TestInsertionSort(array, 0, 0);
                                Checker(array);
                                ToFile(array);
                                CR();
                                CC();
                                break;
                            case "3":
                                TestBubbleSort(array, 0, 0);
                                Checker(array);
                                ToFile(array);
                                CR();
                                CC();
                                break;
                            case "4":
                                TestShakerSort(array, 0, 0);
                                Checker(array);
                                ToFile(array);
                                CR();
                                CC();
                                break;
                            case "5":
                                TestShellSort(array);
                                Checker(array);
                                ToFile(array);
                                CR();
                                CC();
                                Console.WriteLine();
                                break;
                            case "6":
                                flag = false;
                                break;
                        }
                        break;
                    case "2":
                        int [] arr = InitUpperSortedArray();
                        Console.WriteLine("Выберите алгоритм сортировки:\n1)Сортировка выбором\n2)Сортировка вставками\n3)Пузырьковая сортировка\n4)Шейкерная сортировка\n5)Сортировка Шелла\n6)Выход");
                        string secondanswer2 = Console.ReadLine();
                        CC();
                        switch (secondanswer2)
                        {
                            case "1":
                                TestSelectionSort(arr, 0, 0);
                                Checker(arr);
                                ToFile(arr);
                                CR();
                                CC();
                                break;
                            case "2":
                                TestInsertionSort(arr, 0, 0);
                                Checker(arr);
                                ToFile(arr);
                                CR();
                                CC();
                                break;
                            case "3":
                                TestBubbleSort(arr, 0, 0);
                                Checker(arr);
                                ToFile(arr);
                                CR();
                                CC();
                                break;
                            case "4":
                                TestShakerSort(arr, 0, 0);
                                Checker(arr);
                                ToFile(arr);
                                CR();
                                CC();
                                break;
                            case "5":
                                TestShellSort(arr);
                                Checker(arr);
                                ToFile(arr);
                                CR();
                                CC();
                                Console.WriteLine();
                                break;
                            case "6":
                                flag = false;
                                break;
                        }
                        break;
                    case "3":
                        int[] mas = InitLowerSortedArray();
                        Console.WriteLine("Выберите алгоритм сортировки:\n1)Сортировка выбором\n2)Сортировка вставками\n3)Пузырьковая сортировка\n4)Шейкерная сортировка\n5)Сортировка Шелла\n6)Выход");
                        string secondanswer3 = Console.ReadLine();
                        CC();
                        switch (secondanswer3)
                        {
                            case "1":
                                TestSelectionSort(mas, 0, 0);
                                Checker(mas);
                                ToFile(mas);
                                CR();
                                CC();
                                break;
                            case "2":
                                TestInsertionSort(mas, 0, 0);
                                Checker(mas);
                                ToFile(mas);
                                CR();
                                CC();
                                break;
                            case "3":
                                TestBubbleSort(mas, 0, 0);
                                Checker(mas);
                                ToFile(mas);
                                CR();
                                CC();
                                break;
                            case "4":
                                TestShakerSort(mas, 0, 0);
                                Checker(mas);
                                ToFile(mas);
                                CR();
                                CC();
                                break;
                            case "5":
                                TestShellSort(mas);
                                Checker(mas);
                                ToFile(mas);
                                CR();
                                CC();
                                Console.WriteLine();
                                break;
                            case "6":
                                flag = false;
                                break;
                        }
                        break;
                    case "4":
                        flag = false;
                        break;
                }
            }                
        }
        static void Swap (ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static int [] SelectionSort(int[] mas, out int c, out int s)
        {
            int swaps = 0;
            int counter = 0;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    counter++;
                    if (mas[j] < mas[min])
                    {
                        min = j;
                    }
                }
                Swap(ref mas[min], ref mas[i]);
                swaps++;
            }
            c = counter;
            s = swaps;
            return mas;
        }
        static void CC()
        {
            Console.Clear();
        }
        static void CR()
        {
            Console.ReadKey();
        }
        static void TestSelectionSort(int [] array, int counter, int swaps)
        {
            DateTime start = DateTime.Now;
            SelectionSort(array, out counter, out swaps);
            DateTime end = DateTime.Now;
            TimeSpan result = end.Subtract(start);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Время работы: {result.Minutes}:{result.Seconds}:{result.Milliseconds}");
            Console.WriteLine("Число сравнений: " + counter);
            Console.WriteLine("Число перестановок: " + swaps);
        }
        static int [] InitLowerSortedArray()
        {
            Random random = new Random();
            int[] array = new int[100000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 1000);
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[min])
                    {
                        min = j;
                    }
                }
                Swap(ref array[min], ref array[i]);
            }
            return array;
        }
        static int [] InitCasualArray()
        {
            Random random = new Random();
            int[] array = new int[100000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 1000);
            }
            return array;
        }
        static int [] InitUpperSortedArray()
        {
            Random random = new Random();
            int[] array = new int[100000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 1000);
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                Swap(ref array[min], ref array[i]);
            }
            return array;
        }
        static int [] InsertionSort (int [] mas, out long c, out long s)
        {
            long swaps = 0;
            long counter = 0;
            for (int i=1; i<mas.Length; i++)
            {
                for (int j=i; j>0; j--)
                {
                    counter++;
                    if (mas[j - 1] > mas[j])
                    {
                        Swap(ref mas[j - 1], ref mas[j]);
                        swaps++;
                    }
                }
            }
            c = counter;
            s = swaps;
            return mas;
        }
        static void TestInsertionSort (int [] array, long counter, long swaps)
        {
            DateTime start = DateTime.Now;
            InsertionSort(array, out counter, out swaps);
            DateTime end = DateTime.Now;
            TimeSpan result = end.Subtract(start);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Время работы: {result.Minutes}:{result.Seconds}:{result.Milliseconds}");
            Console.WriteLine("Число сравнений: " + counter);
            Console.WriteLine("Число перестановок: " + swaps);
        }
        static int [] BubbleSort (int [] mas, out long c, out long s)
        {
            long swaps = 0;
            long counter = 0;
            for (int i=0; i<mas.Length; i++)
            {
                for (int j=mas.Length-1; j>0; j--)
                {
                    counter++;
                    if (mas[j - 1] > mas[j])
                    {
                        Swap(ref mas[j - 1], ref mas[j]);
                        swaps++;
                    }
                }
            }
            c = counter;
            s = swaps;
            return mas;
        }
        static void TestBubbleSort(int [] array, long counter, long swaps)
        {
            DateTime start = DateTime.Now;
            BubbleSort(array, out counter, out swaps);
            DateTime end = DateTime.Now;
            TimeSpan result = end.Subtract(start);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Время работы: {result.Minutes}:{result.Seconds}:{result.Milliseconds}");
            Console.WriteLine("Число сравнений: " + counter);
            Console.WriteLine("Число перестановок: " + swaps);
        }
        static int [] ShakerSort(int [] mas, out long c, out long s)
        {
            long counter = 0;
            long swaps = 0;
            int leftpos = 0;
            int rightpos = mas.Length - 1;
            do
            {
                for (int i=leftpos; i<rightpos; i++)
                {
                    counter++;
                    if (mas[i] > mas[i + 1])
                    {
                        Swap(ref mas[i], ref mas[i + 1]);
                        swaps++;
                    }
                }
                rightpos--;
                for (int i=rightpos; i>leftpos; i--)
                {
                    counter++;
                    if (mas[i] < mas[i - 1])
                    {
                        Swap(ref mas[i], ref mas[i - 1]);
                        swaps++;
                    }
                }
                leftpos++;
            }
            while (leftpos <= rightpos);
            c = counter;
            s = swaps;
            return mas;
        }
        static void TestShakerSort (int [] array, long counter, long swaps)
        {
            DateTime start = DateTime.Now;
            ShakerSort(array, out counter, out swaps);
            DateTime end = DateTime.Now;
            TimeSpan result = end.Subtract(start);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Время работы: {result.Minutes}:{result.Seconds}:{result.Milliseconds}");
            Console.WriteLine("Число сравнений: " + counter);
            Console.WriteLine("Число перестановок: " + swaps);
        }
        static void Checker (int [] arr)
        {
            bool flag = true;
            for (int i=0; i<arr.Length-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Массив отсортирован верно");
            }
            else
            {
                Console.WriteLine("Массив отсортирован неверно");
            }
        }
        static void ToFile (int [] mas)
        {
            FileStream file = new FileStream(@"d:\L7\7.2\sorted.dat", FileMode.OpenOrCreate);
            BinaryWriter writer = new BinaryWriter(file);
            for (int i=0; i<mas.Length; i++)
            {
                writer.Write(mas[i]);
            }
            writer.Close();
        }
        static int [] ShellSort (int [] mas)
        {
            foreach (int step in mas)
            {
                for (int i=step; i<=mas.Length-1; i++)
                {
                    int j = i;
                    int temp = mas[i];
                    while (j >= step && temp < mas[j - step])
                    {
                        mas[j] = mas[j - step];
                        j -= step;
                    }
                    mas[j] = temp;
                }
            }
            return mas;
        }
        static void TestShellSort (int [] mas)
        {
            DateTime start = DateTime.Now;
            ShellSort(mas);
            DateTime end = DateTime.Now;
            TimeSpan result = end.Subtract(start);
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Время работы: {result.Minutes}:{result.Seconds}:{result.Milliseconds}");
            Console.WriteLine("Число сравнений: " + "0");
            Console.WriteLine("Число перестановок: " + "0");
        }
    }
}
