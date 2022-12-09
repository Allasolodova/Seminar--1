//Семинар 5

//Задача 34
//Задайте массив,заполненный случайными положительными трёхзначными числами. Напишите программу,которая
//покажет количество чётных чисел в массиве.
//[345,897, 568, 234]   -> 2

/*int size = ReadInt("Введите размерность массива:  ");
int[] numbers = new int[size];


FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        result++;
    }
}
if (result % 10 == 1)
{
    Console.WriteLine($"В массиве {result} чётное число");
}
if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
{
    Console.WriteLine($"В массиве {result}  чётных чисел");
}
else


   Console.WriteLine($"В массиве {result} чётных чисел");


//-------------------------------Методы--------------------------
void FillArrayRandomNumbers(int [] array) //Заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 999);
    }
}

void PrintArray(int[] array) //Вывод массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int ReadInt(string message) //Функция ввода
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}*/


 //Задача 36
 //Задайте одномерный массив,заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
 //(индексы элементов должны быть нечётными(1,3,5 и т.д.)).
 // [3, 7, 23, 12] -> 19  [-4, -6, 89, 6] -> 0

 /*int size = ReadInt("Введите размерность массива:  ");
 int min = ReadInt("Введите минимальное число массива:  ");
 int max = ReadInt("Введите максимальное число массива:  ");
 int [] numbers = new int[size];

 FillArrayRandomNumbers(numbers);
 PrintArray(numbers);
 int result = 0;

 for (int i = 0; i < numbers.Length; i++)
 { 
    if (i % 2 != 0) 
    {
        result += numbers[i];
    }
 }
 Console.WriteLine($"Сумма элементов нечётных позиций =  {result}");
 //----------------------------Методы---------------------------------
 void FillArrayRandomNumbers(int [] array) //Заполнение массива
 {
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
 }

 void PrintArray(int [] array) //Вывод массива на экран
 {
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
 }

 int ReadInt(string message) //Функция ввода
 {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
 }*/

 //-------------------------------------------------------------------------------------- 
 //Задача 37
 // Найдите произведение пар чисел в одномерном массиве.
 //Парой считаем первый и последний элемент, второй предпоследний
 //и т.д. Результат записать в новом массиве.
 //[1 2 3 4 5] -> 5 8 3  [6 7 3 6] -> 36 21

 /*Console.WriteLine("Введите размер массива: ");
 int size = Convert.ToInt32(Console.ReadLine());
 int[] array = new int[size];
 FillArray(array);
 int[] array2 = new int[size];
 Console.WriteLine(" ");
 PrintArray(array);
 MultiplyPairs(array);
 Console.WriteLine(" ");
 PrintArray2(array2);

 void FillArray(int[] array)
 {
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }

 }
 void PrintArray(int[] array)
 {
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i] + " "} ");
    }
    
 }

 void MultiplyPairs(int[] array)
 {
    for (int i = 0; i < array.Length / 2; i++)
    {
        array2[i] = array[i] * array[array.Length - i - 1];
    }
 }

 void PrintArray2(int[] array2)
 {
    for (int i = 0; i < array2.Length; i++)
    { 
        Console.Write($"{array2[i] + " "} ");
    }
 }*/
 --------------------------------------------------------------------------------

 //Задача 38
 //Задайте массив целых чисел  от -10 до 10.
 //Найдите разницу между максимальным и минимальным элементами массива

 /*int size =  ReadInt("Введите размерность массива:  ");
 int min = -10; //ReadInt("Введите минимальное число массива:  ");
 int max = 10; //ReadInt("Введите максимальное число массива:  ");
 int [] numbers = new int[size];

 FillArrayRandomNumbers(numbers);
 PrintArray(numbers); 

 int maxFillarray = numbers[0];
 int minFillarray = numbers[0];
  
 for (int i = 0; i < numbers.Length; i++)
 {
    if (numbers[i] > maxFillarray)
    {
        maxFillarray = numbers[i];
    }
    if (numbers[i] < minFillarray)
    {
        minFillarray = numbers[i];
    }
 }
 Console.WriteLine($"Разница между максимальным и минимальным числом = {maxFillarray - minFillarray}");

 //-----------------------------------------Методы---------------------------------
 void FillArrayRandomNumbers(int [] array) //Заполнение массива
 {
    for (int i = 0; i <  array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
 }

 void PrintArray(int[] array) //Вывод массива на экран
 {
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

 }

 int ReadInt(string message) //Функция ввода
 {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
 }











    

 





