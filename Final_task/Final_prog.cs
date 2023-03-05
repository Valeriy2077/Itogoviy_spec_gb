Console.Clear();
string[] array = new string[] { "Hello", "13", "world", "=)" };
string[] arrayN = new string[array.Length];

void NewArray()
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayN[j] = array[i];
            j++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
NewArray();
PrintArray(arrayN);

