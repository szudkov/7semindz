Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

int[,] Fullarr = new int[m, n];
Fullarr = NewArr(array);

WriteArray(Fullarr);

Console.Write($"Cреднее арифметическое равно ");
for (int i = 0; i < n; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < m; j++)
  {
    arithmeticMean += Fullarr[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / m, 1);
  Console.WriteLine($"столбца № {i+1} {arithmeticMean}");
}

int[,] NewArr (int[,] array)
{
  int[,] Fullarr = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Fullarr[i, j] = Convert.ToInt32(array[i, j]);
    }
  }
  return Fullarr;
}

void WriteArray (int[,] Fullarr)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        Console.Write(Fullarr[i, j] + " ");
      }
      Console.WriteLine();
  }
}