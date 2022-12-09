                                                  // Семинар 
//Задача   41
//Пользователь  вводит с клавиатуры M чисел.
//Посчистайте,сколько чисел строго больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1,-7, 567, 89, 223 -> 4

/*Console.Write("Введите числа через пробел:  ");
int[] numbers = GetArrayFromString(Console.ReadLine()!);
Console.WriteLine($"Количество чисел больше 0 -> {GetCountPositiveElements(numbers)}");
Console.WriteLine();

int[] GetArrayFromString(string stringArray)
{
    string[] numS = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}

int GetCountPositiveElements(int[] array)
{
    int count = 0;
    foreach (var i in array)
    {
        if (i > 0) count++;
    }
    return count;
}*/

//Задача 43
//написать программу, которая на вход принимает массив из любого количества
//элементов  (не менее 6) в промежутке от 0 до 100, а на выходе
//выводит этот же массив, но отсортированный по возрастанию меньшего числа к большеиу.

/*int[] array = GetArray(10,0,100);
Console.WriteLine($"{String.Join( ",",array)} ");
ReverseArr(array);
Console.WriteLine($"{String.Join( ",",array)} ");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] ReverseArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[i])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
}*/












    

 





