/*
    Лекция #3 Печать массива и Сортировка массива.
*/

int[] arr = { 1, 3, 5, 6, 4, 2, 7 };

void Print(int[] array)
{
    System.Console.Write("Array: ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void ArraySortFromMinToMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void ArraySortFromMaxToMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

Print(arr);
ArraySortFromMinToMax(arr);
Print(arr);
ArraySortFromMaxToMin(arr);
Print(arr);
