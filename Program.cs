//                                                   Семинар 9


//____________________________Задача 64:_________________________________
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*  int n = InputInt("Введите число больше нуля:  ");
int i = 1;
Console.WriteLine(NaturalNumber(n, i));
int NaturalNumber(int n, int i)
{
    if (n == i)
        return n;
    else
        Console.Write($"{NaturalNumber(n, i + 1)}, ");        
  
         
    return i;
}
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
} */
 

//___________________________Задача 66:_________________________________
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

/*Console.Write("Введите начальное число M:  ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Введите начальное число N:  ");
int numN = int.Parse(Console.ReadLine());
GapNumberSum(numM, numN, 0);
//Метод нахождения суммы натуральных элементов в промежутке от M до N;
void GapNumberSum (int numM, int numN, int sum)
{
    if (numM > numN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numM++);
    GapNumberSum(numM, numN, sum);
}*/


//___________________________Задача 68:__________________________________
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

 /* Console.WriteLine("Введите два положительных числа: M и N.");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}*/       