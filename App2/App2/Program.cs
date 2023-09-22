using System;
using System.Collections.Generic;
using System.Linq;

namespace App2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int TaskNumber;
            do
            {
                Console.WriteLine(
                    "\n\nВведите номер задания от 1 до 5. \nВведите 0 для запуска всех заданий последовательно. \nВведите 12345 чтобы закрыть программу.\n");

                if (int.TryParse(Console.ReadLine(), out TaskNumber))
                {
                    switch (TaskNumber)
                    {
                        case 0:
                            Console.WriteLine("----------First task №146---------");
                            firstTask();
                            Console.WriteLine(" \n ----------Second task №153---------");
                            secondTask();
                            Console.WriteLine(" \n ----------Third task №172---------");
                            thirdTask();
                            Console.WriteLine(" \n ----------Fourth task №209---------");
                            fourthTask();
                            Console.WriteLine(" \n ----------Fifth task №60---------");
                            fifthTask();
                            break;
                        case 1:
                            Console.WriteLine("----------First task №146---------");
                            firstTask();
                            break;
                        case 2:
                            Console.WriteLine(" \n ----------Second task №153---------");
                            secondTask();
                            break;
                        case 3:
                            Console.WriteLine(" \n ----------Third task №172---------");
                            thirdTask();
                            break;
                        case 4:
                            Console.WriteLine(" \n ----------Fourth task №209---------");
                            fourthTask();
                            break;
                        case 5:
                            Console.WriteLine(" \n ----------Fifth task №60---------");
                            fifthTask();
                            break;
                        default:
                            Console.WriteLine("Такого номера задания нет. Введите число от 1 до 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Неверное значение. Введите число от 1 до 5.");
                }
            } while (TaskNumber != 12345);
        }

        
        
        /// <summary>
        /// Дан массив, состоящий из n натуральных чисел.
        /// Образовать новый массив, элементами которого являются элементы исходного,
        /// оканчивающиеся на цифру k.
        /// </summary>
        static void firstTask()
        {
            Console.WriteLine("Task 1 \nВведите развер массива: ");
            int.TryParse(Console.ReadLine(), out int sizeArray);
            int[] arrayOriginal = new int[sizeArray];

            Console.Write("Полученый массив: \n [ ");
            Random random = new();
            for (int i = 0; i < sizeArray; i++)
            {
                arrayOriginal[i] = random.Next(1, 99);
                Console.Write($"{arrayOriginal[i]}, ");
            }

            Console.Write("] \nВведите цифру, на которую окончится новый массив: ");
            int.TryParse(Console.ReadLine(), out int numberToCheck);

            int[] arrayNotOriginal = arrayOriginal.Where(number => number % 10 == numberToCheck).ToArray();

            if (arrayNotOriginal.Length == 0)
            {
                Console.WriteLine($"На цифру {numberToCheck} не оканчивается ни одно число массива.");
                Console.Write("Итоговый массив пуст: \n [ ");
            }
            else
            {
                Console.Write("Итоговый массив: \n [ ");
            }

            foreach (int number in arrayNotOriginal)
            {
                Console.Write(number + ", ");
            }

            Console.Write("]\n");
        }


        
        /// <summary>
        /// В массивах А[К] и B[L] хранятся коэффициенты двух многочленов степеней K и L.
        /// Поместить в массив С[М] коэффициенты их произведения.
        /// (Числа К, L, М — натуральные, М = K + L;
        /// элемент массива с индексом i содержит коэффициент при х в степени i.)
        /// </summary>
        static void secondTask()
        {
            Console.WriteLine("Task 2 \nВведите развер массивов А и В (одно число): ");
            int.TryParse(Console.ReadLine(), out int sizeArray);
            int[] arrayA = new int[sizeArray];
            int[] arrayB = new int[sizeArray];

            Console.Write("Созданы массивы = \nA [ ");
            Random random = new();
            for (int i = 0; i < arrayA.Length; i++)
            {
                arrayB[i] = random.Next(1, 99);
                arrayA[i] = random.Next(1, 99);
                Console.Write($"{arrayA[i]}, ");
            }

            Console.Write("]\nВ [ ");
            for (int i = 0; i < arrayB.Length; i++)
            {
                Console.Write($"{arrayB[i]}, ");
            }

            Console.Write("]\nРезультат произведения многочленов: \n");
            int[] resultPolynomial = new int[sizeArray * 2 - 1]; // размер массива с результатом;
            for (int i = 0; i < sizeArray; i++)
            {
                for (int j = 0; j < sizeArray; j++)
                {
                    resultPolynomial[i + j] += arrayA[i] * arrayB[j];
                }
            }

            for (int i = 0; i < resultPolynomial.Length; i++)
            {
                Console.Write($"{resultPolynomial[i]}x^{i}\n");
            }

            Console.Write("\nИтоговый массив С c коэффициентами: \n С = [ ");
            for (int i = 0; i < resultPolynomial.Length; i++)
            {
                Console.Write($"{resultPolynomial[i]}, ");
            }

            Console.Write("]");

        }


        
        /// <summary>
        /// Написать алгоритм смены мест в заданном массиве 1-го элемента с последним, 2-го с предпоследним и так далее.
        /// </summary>
        static void thirdTask()
        {
            Console.WriteLine("Task 3 \nВведите размер изначального массива: ");
            int.TryParse(Console.ReadLine(), out int sizeArray);

            int[] reverseArray = new int[sizeArray];
            Console.Write("Созданный массив = \n [ ");
            Random random = new();
            for (int i = 0; i < sizeArray; i++)
            {
                reverseArray[i] = random.Next(1, 99);
                Console.Write($"{reverseArray[i]}, ");
            }

            Console.Write("]\n");

            int length = reverseArray.Length;
            for (int i = 0; i < length / 2; i++)
            {
                (reverseArray[i], reverseArray[length - 1 - i]) = (reverseArray[length - 1 - i], reverseArray[i]);
            }

            Console.Write("Перевернутый массив имеет вид: \n [ ");
            foreach (int element in reverseArray)
            {
                Console.Write(element + ", ");
            }

            Console.Write("]");
        }


        
        /// <summary>
        /// Для арифметических операций с большими числами, которые не могут быть представлены в памяти компьютера,
        /// используется следующий прием. Каждая цифра таких чисел записывается в отдельный элемент массива,
        /// и необходимые операции проводятся с элементами массива цифр. Составить программу:
        /// а) выполняющую сложение 20-значных чисел;
        /// б) выполняющую вычитание 30-значных чисел.
        /// </summary>

        static void fourthTask()
        {
            Console.WriteLine("1 -> Сложение 20-ти значных чисел\n2 -> Вычитание 30-тизначных чисел:");
            int.TryParse(Console.ReadLine(), out int choice);
            if (choice == 1)
            { 
                Console.WriteLine("Task 4\nа) Введите первое 20-тизначное число (без пробелов):");
                string FirstNumber20 = Console.ReadLine();
                Console.WriteLine("Введите второе 20-ти значное число (без проблеов):");
                string SecondNumber20 = Console.ReadLine();

                if (FirstNumber20.Length != 20 || SecondNumber20.Length != 20)
                {
                    Console.WriteLine("Числа должны быть длиной в 20 цифр.");
                }
                else
                {
                    // Преобразуем строки с числами в массивы цифр
                    int[] array1 = new int[FirstNumber20.Length];
                    int[] array2 = new int[SecondNumber20.Length];
                    for (int i = 0; i < FirstNumber20.Length; i++)
                    {
                        array1[i] = int.Parse(FirstNumber20[i].ToString());
                        array2[i] = int.Parse(SecondNumber20[i].ToString());
                    }
                    Console.Write("Первое число: ");
                    for (int i = 0; i < FirstNumber20.Length; i++)
                    {
                        Console.Write(array1[i]);
                    }
                    Console.Write("\nВторое число: ");
                    for (int i = 0; i < FirstNumber20.Length; i++)
                    {
                        Console.Write(array2[i]);
                    }

                    // Выполняем сложение
                
                    int maxLength = Math.Max(array1.Length, array2.Length) + 1;
                    int[] result = new int[maxLength];
                    int carry = 0;
                
                    Console.WriteLine("\nПолученное число: ");
                    for (int i = maxLength - 1; i >= 0; i--)
                    {
                        int digit1;
                        int digit2;

                        if (i < array1.Length)
                        {
                            digit1 = array1[i];
                        }
                        else
                        {digit1 = 0;}

                        if (i < array2.Length)
                        {
                            digit2 = array2[i];
                        }
                        else
                        {
                            digit2 = 0;
                        }

                        int sum = digit1 + digit2 + carry;
                        result[i] = sum % 10;
                        carry = sum / 10;
                    }
                    Console.WriteLine("Сумма: " + FirstNumber20 + " + " + SecondNumber20 + " = " + string.Join("", result));
                }
            }

            if (choice == 2)
            {
                Console.WriteLine("Введите первое 30-ти значное число (без пробелов): ");
                string FirstNumber30 = Console.ReadLine();
                Console.WriteLine("Введите второе 30-ти значное число (без проблеов): ");
                string SecondNumber30 = Console.ReadLine();

                if (FirstNumber30.Length != 30 || SecondNumber30.Length != 30)
                {
                    Console.WriteLine("Числа должны быть длиной в 30 цифр.");
                }
                else
                {
                    // Преобразуем строки с числами в массивы цифр
                    int[] array1 = new int[FirstNumber30.Length];
                    int[] array2 = new int[SecondNumber30.Length];
                    for (int i = 0; i < FirstNumber30.Length; i++)
                    {
                        array1[i] = int.Parse(FirstNumber30[i].ToString());
                        array2[i] = int.Parse(SecondNumber30[i].ToString());
                    }
                    Console.Write("Первое число: ");
                    for (int i = 0; i < FirstNumber30.Length; i++)
                    {
                        Console.Write(array1[i]);
                    }
                    Console.Write("\nВторое число: ");
                    for (int i = 0; i < FirstNumber30.Length; i++)
                    {
                        Console.Write(array2[i]);
                    }

                    // Выполняем вычитание
                
                    int maxLength = Math.Max(array1.Length, array2.Length) + 1;
                    int[] result = new int[maxLength];
                    int carry = 0;
                
                    Console.WriteLine("\nПолученное число: ");
                    for (int i = maxLength - 1; i >= 0; i--)
                    {
                        int digit1;
                        int digit2;

                        if (i < array1.Length)
                        {
                            digit1 = array1[i];
                        }
                        else
                        {
                            digit1 = 0;
                        }

                        if (i < array2.Length)
                        {
                            digit2 = array2[i];
                        }
                        else
                        {
                            digit2 = 0;
                        }

                        int difference = digit1 - digit2 - carry;
                        if (difference < 0)
                        {
                            difference += 10;
                            carry = 1;
                        }
                        else
                        {
                            carry = 0;
                        }

                        result[i] = difference;
                    }
                    Console.WriteLine("Разность: " + FirstNumber30 + " - " + SecondNumber30 + " = " + string.Join("", result));
                }
            }
        }

        
        
        /// <summary>
        /// Найти и запомнить в массиве все максимумы и минимумы функции y = a*e^(-bx) * sin(wx + f)
        /// при изменении аргумента от 0 до 5 с шагом 0,1.
        /// </summary>
        static void fifthTask()
        {
            Console.WriteLine("Task 5");
            Random random = new();
            double a = random.Next(0, 5);
            double e = random.Next(0, 5);
            double b = random.Next(0, 5);
            double w = random.Next(0, 5);
            double f = random.Next(0, 5);

            Console.WriteLine(
                $"Дана функция: y = a*e^(-bx) * sin(wx + f)\nГде: a = {a}, e = {e}, b = {b}, w = {w}, f = {f};");

            //Массивы для максимальных и минимальных аргументов;
            List<double> maxValuesX = new List<double>();
            List<double> minValuesX = new List<double>();

            for (double x = 0.0; x <= 5.0; x += 0.1)
            {
                double y = a * e * Math.Exp(-b * x) * Math.Sin(w * x + f);
                double y1 = a * Math.Exp(-b * (x - 0.1)) * Math.Sin(w * (x - 0.1) + f);
                double y2 = a * Math.Exp(-b * (x + 0.1)) * Math.Sin(w * (x + 0.1) + f);

                // Проверка, является ли текущее значение y максимумом или минимумом;
                if (y > y1 && y >= y2)
                {
                    maxValuesX.Add(x);
                    Console.WriteLine($"Максимум: x = {x}, y = {y}");
                }
                else if (y < y1 && y <= y2)
                {
                    minValuesX.Add(x);
                    Console.WriteLine($"Минимум: x = {x}, y = {y}");
                }
            }

            double[] arrayMax = maxValuesX.ToArray();
            Console.Write("Массив с максимальными значениями: [ ");
            for (int i = 0; i < arrayMax.Length; i++)
            {
                Console.Write($"{arrayMax[i]}; ");
            }
            Console.Write("]\nМассив с минимальными значениями: [ ");
            double[] arrayMin = minValuesX.ToArray();
            for (int i = 0; i < arrayMin.Length; i++)
            {
                Console.Write($"{arrayMin[i]}; ");
            }
            Console.Write("]");
        }
    }
}