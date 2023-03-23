void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(1, 10);
}

void ProizvedenieElements(int[] array)
{
  for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
    Console.Write($"{array[i] * array[array.Length - 1 - i]} ");
}

Console.Clear();
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ProizvedenieElements(array);
