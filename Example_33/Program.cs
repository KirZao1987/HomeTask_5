void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(-9, 10);
}

string SearchNumberInArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
          return "yes";
    }
    return "no";
}

Console.Clear();
Console.Write("Введите кол-во элементов массива ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write("Введите число: ");
int k = int.Parse(Console.ReadLine()!);
Console.WriteLine(SearchNumberInArray(array, k));