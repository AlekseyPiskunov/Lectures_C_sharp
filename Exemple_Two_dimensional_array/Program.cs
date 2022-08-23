//Пишем двухмерный массив и заполняем его.
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             System.Console.Write($"{matr[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// System.Console.WriteLine();
// PrintArray(matrix);

//_____________________________________
//Разбираемся с методом который вызывает в себе себя. Знакомство с рекурсивным методом.
// int Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// System.Console.WriteLine(Factorial(4));

//_____________________________________
// Метод фибоначи
// int Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }

// for (int i = 1; i < 30; i++)
// {
//     System.Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }