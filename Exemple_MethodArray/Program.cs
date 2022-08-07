Console.Clear();

int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };

int n = array.Length; // n - длина массива
int find = 18; // будем искать элемент 4
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"Индекс - {index}");
        break;
    }
    index++;
}