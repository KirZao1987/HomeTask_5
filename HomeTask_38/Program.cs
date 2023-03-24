void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
      array[i] = Math.Round(new Random().NextDouble() *(100 - 1) + 10, 2);
}
double max = array[0];
double min = array[0];

for (int i = 1; i < array.Length; i++)
{
  if (array[i] > max)
  {
    max = array[i];
  }
  if (array[i] < min)
  {
    min = array[i];
  }
}
double diff = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами {diff}");
