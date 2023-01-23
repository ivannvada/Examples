int[] array = { 32, 52, 74, 4, 64, 25, 82, 26};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}