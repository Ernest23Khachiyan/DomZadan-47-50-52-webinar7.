/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/


Console.Clear();
Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

GetDoubleArray(array);
WriteArray(array);

Console.WriteLine();
void GetDoubleArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void WriteArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double alignNumber = Math.Round(array[i, j], 1);
            Console.Write(alignNumber + " ");
        }
        Console.WriteLine();
    }
}


//====================================================================================================================================================================================================


// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет


Console.Clear();
Console.Write("Ввод с клавиатуры количества строк массива: ");
int IdString = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввод с клавиатуры количества столбцов массива: ");
int IdColumn = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(IdString, IdColumn, -10, 10);  //заполнит массив числами от -10 до 10 вкл
PrintArray(array);
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write("{0,4:0}", arr[i, j]);
        }
        Console.WriteLine();
    }
}
int[,] FillArray(int IdStrArray, int IdColArray, int min, int max)
{
    Random rnd = new Random();
    int[,] resultArray = new int[IdStrArray, IdColArray];
    for (int i = 0; i < IdStrArray; i++)
        for (int j = 0; j < IdColArray; j++)
        {
            resultArray[i, j] = rnd.Next(min, max + 1);
        }
    return resultArray;
}
Console.Write("Введите индекс строки: ");
int unknownString = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int unknownColumn = Convert.ToInt32(Console.ReadLine());
if (unknownColumn < IdColumn && unknownString < IdString)
{
    Console.WriteLine("Значением элемента массива является ->{0,4:0}", array[unknownString, unknownColumn]);
}
else Console.WriteLine("Индекс находится за пределами массива, попробуйте еще раз");


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//второй способ

Console.Clear();
Console.WriteLine("Ввод с клавиатуры количества строк и столбцов массива");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[x, y];

for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
array[i, j] = Convert.ToInt32(new Random().Next(0, 10)); //заполнит массив числами до 10
}

for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
Console.Write(array[i, j] + "\t ");
Console.WriteLine();
}

Console.WriteLine("Введите индексы элемента в двумерном массиве");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a > x || b > y)
{
Console.WriteLine("Индекс находится за пределами массива");
}

else
{
object c = array.GetValue(a, b);
Console.Write($"Значение элемента в двумерном массиве: {c}");
}



//=========================================================================================================================================================================================================


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();
Console.Write("Введите значение m количества строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n количества столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

DoubleArray(array);

Console.WriteLine();

void DoubleArray(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 9;
    }
  }
}

int[,] arrayWhole = new int[m, n];
arrayWhole = ArrayConversion(array);

WriteArrayInt(arrayWhole);

Console.Write($"\nCреднее арифметическое столбцов:\n");
for (int i = 0; i < n; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < m; j++)
  {
    arithmeticMean += arrayWhole[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / m, 1);
  Console.WriteLine($"-столбец № {i+1}: {arithmeticMean}");
}

int[,] ArrayConversion (double[,] array)
{
  int[,] arrayWhole = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      arrayWhole[i, j] = Convert.ToInt32(array[i, j]);
    }
  }
  return arrayWhole;
}

void WriteArrayInt (int[,] arrayWhole){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        Console.Write(arrayWhole[i, j] + " ");
      }
      Console.WriteLine();
  }
}

