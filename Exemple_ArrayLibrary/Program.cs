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
// Рандомно заполняет массив
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
//печатает каждый элемент
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
// Будет искать индекс 

int[] array = new int[10]; // Создал массив с 10-ю элементами.

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4); // показывает индекс указанного элемента(4)
Console.WriteLine(pos);