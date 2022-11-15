Console.Clear();
string[] startArray = new string[10] {"Geek", "for", "fire", "if", "77", "Box", "Clear", "data", "info", "moon"};
string[] finishArray = new string[startArray.Length];

void SortedArray(string[] startArray, string[] finishArray)
{
    int count = 0;
    for (int i = 0; i < startArray.Length; i++)
    {
    if(startArray[i].Length <= 3)
        {
        finishArray[count] = startArray[i];
        count++;
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

SortedArray(startArray, finishArray);
PrintArray(finishArray);