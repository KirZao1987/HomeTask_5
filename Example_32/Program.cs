void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(-9, 10);
}
void ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
      array[i] *= (-1);
}


Console.Clear();
//Console.Write("Введите кол-во элементов массива ");
//int n = int.Parse(Console.ReadLine()!);
int[] array = new int[12];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ChangeArray(array);
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");
