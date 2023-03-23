void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(1, 100);
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
