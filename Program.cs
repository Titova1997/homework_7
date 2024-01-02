// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.
// Пример
// M = 1; N = 5-> "1, 2, 3, 4, 5"
// M = 4; N = 8-> "4, 5, 6, 7, 8"

// похоже на второе задание 
// только мы начинаем не с 1 а с того числа которое указано 

// int m = new Random().Next(1, 6);
// int n = new Random().Next(m + 1, 6);
// Console.WriteLine("Наше число" + m);
// Console.WriteLine("Наше число" + n);

// int step = 1;

// PrintNumbers(m, n);

// void PrintNumbers(int m, int n)
// {
//     if (m > n) 
//     return;
//     Console.WriteLine(m + " ");
//     PrintNumbers(m + step, n);
// }

// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// Пример
// m = 2, n = 3->A(m, n) = 29

// int m = 3;
// int n = 2;
// ackermann(m, n);

// int ackermann(int m, int n)

// {
//     if (m == 0)
//     {
//         return n + 1;
//     }

//     else if (m > 0 && n == 0)
//     {
//         return ackermann(m - 1, 1);
//     }

//     else
//     {
//         return ackermann(m - 1, ackermann(m, n - 1));
//     }
// }
// Console.WriteLine(ackermann(m, n));


// Задача 3: Задайте произвольный массив. Выведите его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

// int[] arr = { 1, 2, 5, 0, 10, 34 };
// PrintArrEl(arr, arr.Length - 1);

// void PrintArrEl(int[] arr, int index)
// {
//     if (index >= 0)
//     {
//         Console.Write(arr[index] + " ");
//         PrintArrEl(arr, index - 1);
//     }
// }
// Console.WriteLine();