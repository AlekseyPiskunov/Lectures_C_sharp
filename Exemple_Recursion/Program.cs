//_______________________________________________________________________
// Рекурсия. (вывод чисел от a до b)

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }
// System.Console.WriteLine(NumbersRec(1, 10));

// В обратную сторону____________________________________________________
// string NumbersRec(int a, int b)
// {
//     if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
//     else return String.Empty;
// }
// System.Console.WriteLine(NumbersRec(1, 10));

//_______________________________________________________________________
// Сумма элементов от 1 до n.

// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }
// System.Console.WriteLine(SumRec(10));

//_______________________________________________________________________
// Факториал числа. (от 1 до n)

// int FactorialFor(int n)
// {
//     if (n == 1) return 1;
//     else return n * FactorialFor(n - 1);
// }
// System.Console.Write(FactorialFor(5));

//_______________________________________________________________________
// Вычислить число "a" в степени "n".

// int PowerFor(int a, int n)
// {
//     if (n == 0) return 1;
//     else return PowerFor(a, n - 1) * a;
// }
// System.Console.WriteLine(PowerFor(2, 10));

//_______________________________________________________________________
/* В некотором машинном алфивите имеются четыру буквы "а", "и", "с", и "в".
Покажите все слова, состоящие из Т букв, которые можно построить из букв этого алфавита. 
*/

// int n = 1;
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }
// }

// FindWords("аисв", new char[6]);

//_______________________________________________________________________
// Обход директорий.

// string path = "E:/Кино";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }

//_______________________________________________________________________
// Рекурсия которая может ходить по папкам и смотрит что там находиться.

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);

//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + "  ");
//     }

//     FileInfo[] files = catalog.GetFiles();

//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }

// string path = @"E:\Кино";
// CatalogInfo(path);