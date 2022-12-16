//                                                 Семинр 8

//                                                Задача 53

//Задайте двумерный массив.Напишите программу,которая поменяет местами первую и последнюю строку массива.
//Например ,задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//в итоге получается вот такой массив;
//8 4 2 4
//5 9 2 3
//1 4 7 2 

/*Console.Clear();
Console.Write("Введите колличество строк;  ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов:  ");
int columns = int.Parse(Console.ReadLine()!);
int[,] arrayFirst = GetArray(rows, columns, 10, 99);
PrintArray(arrayFirst);
Console.WriteLine("===================");
SortArray(arrayFirst);
PrintArray(arrayFirst);
if (arrayFirst.GetLength(0) == arrayFirst.GetLength(1))
{
    int[,] arraySecond = RouteArray(arrayFirst);
    PrintArray(arraySecond);
}
else
{
    Console.WriteLine("Матрица не квадратная i <> j");


}


int[,] GetArray(int rows, int columns, int minValues, int maxValues)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            array[i, j] = new Random().Next(minValues, maxValues + 1);
        }
    }
    return array;
}

void SortArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write($"{array[i, j]}  ");
        }
        
        Console.WriteLine("]");
    }
}

int[,] RouteArray(int[,] array)
{
    int[,] array2 = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
          for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[j, i] = array[i, j];
        }
    }
    
    return array2;
}*/

  //                                            

  //                                       Задача 54

 // Зададйте двумерный массив.  напишите программу,которая упорядочит по убыванию элементы каждой строки двумерного массива.
 //Например,задан массив:
 //1 4 7 2
 //5 9 2 3
 //8 4 2 4
 //В итоге получился вот такой массив:
 //7 4 2 1
 //9 5 3 2
 //8 4 4 2

/* int[,] table = new int[3, 4];
 FillArrayRandom(table);
 PrintArray(table);
 SortTolower(table);
 Console.WriteLine();
 PrintArray(table);

 void FillArrayRandom(int[,] array)
 {
    for (int i = 0; i < array.GetLength(0); i++)
    {
          for (int j = 0; j < array.GetLength(1); j++)
          {
            array[i, j] = new Random().Next(1, 10);
          }

    }

 }

 void SortTolower(int[,] array)
 {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
 }

 void PrintArray(int[,] array)
 {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
 }*/

//                                      Задача 56
//Задайте прямоугольный двумерный массив. Напишите программу,которая будет находить
//строку с нименьшей суммой элементов.
//Например,задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа  считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
//1 строка

/*int[,] table = new int[4, 4];
FillArrayRandom(table);
PrintArray(table);
Console.WriteLine();
NumberPowMinSumElements(table);

void NumberPowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < table.GetLength(1); i++)
    {
        minRow += table[0, i];
    }
    for (int i = 0; i < table.GetLength(0); i++)
    {
         for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
         if (sumRow < minRow)
         {
            minRow = sumRow;
            minSumRow = i;
         }
         sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка  ");
}

void PrintArray(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            Console.Write($"{array[i, j]} ");
         }
         Console.WriteLine();
     }
}

void FillArrayRandom(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            array[i, j] = new Random().Next(1, 10);
         }
     }
}*/

//                                           Задача 58

//задайте две матрицы. Напишите программу,которая будет находить произведение двух иатриц.
//Например, две матрицы:
//2 4| 3 4
//3 2 | 3 3
//Результатирующая матрица будет:
//18 | 20
//15 | 18

/*Console.WriteLine("Введите размер матриц и диапазон случайных значений:  ");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел от 1 до ");

int[,] firstMatrix = new int[m, n];
CreateArray(firstMatrix);
Console.WriteLine($"Первая матрица: ");
WriteArray(firstMatrix);

int[,] secomdMatrix = new int[n, p];
CreateArray(secomdMatrix);
Console.WriteLine($"Вторая матрица: ");
WriteArray(secomdMatrix);

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMatrix, secomdMatrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц: ");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMatrix, int[,] secomdMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secomdMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }

}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}*/



