Console.Clear();

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
// Рандомно заполняет массив.
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}
// Печатает каждый элемент.
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
// Будет искать индекс.
int? Max(int[] maximum)
{
    int count = maximum.Length;
    if (count == 0)
    {
        return null;
    }
    int index = 1;
    int max = maximum[0];
    while (index < count)
    {
        if (maximum[index] > max)
        {
            max = maximum[index];
        }
        index++;
    }
    return max;
}
// ищет максимальный элемент.
int[] array = new int[15]; // Создал массив с 10-ю элементами.

FillArray(array);
array[0] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4); // показывает индекс указанного элемента(4)
Console.WriteLine($"Индекс элемента 4 = [{pos}]!");

int? max = Max(array); // показывает максимальный элемент.
Console.WriteLine($"Максимальный элемент - {max}!");
