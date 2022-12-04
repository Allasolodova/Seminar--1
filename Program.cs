//YнАПИШИТЕ  цикл,который принимает на вход два числа(A и B) и возводит число Aв натуральную степень B.
//3, 5 ->243
//2, 4 -> 16
//Задача 25 

/*Console.Write(("Введите число:  ") );
int a= int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{a} в степени {b} = {Pow(a,b) }");


int Pow(int num, int rank)

{

    if(b == 0) return 1;

    int result = num;
    for (int i = 2; i <= rank; i++)
    {
        result *= num;
    }
    return result;
}*/


//____________________________________________________________

// Задача 27
//Напишите программу,которая принимает на вход число и выдаёт сумму цифр в числе
//452 -> 11
//82 -> 10
//9012 -> 12

/*Console.Write("Введите число:");
int num = int. Parse(Console.ReadLine()!);

int GetSumNums(int number)
{
    int sum = 0;
    while(number>0)
    {
        sum+=number%10;
        number/=10;
    
    }
    return sum;


}
Console.WriteLine(GetSumNums(num));*/

 //------------------------------------------------------

 /*Console.Write("Ввендите число: ");
 int num = int.Parse(Console.ReadLine()!);

 int GetSize(int number)  
 {
    int i =10;
    int size = 1;
    while(true)
    {
        if(number / i !=0)
        {
            size+=1;
        }
        else
        {
            break;
        }
        i *= 10;
    }
    return(size);

 } 
 Console.WriteLine(GetSize(num));*/

// Задача 29
//Напишите программу,которая задаёт массив из 8 элементов и выводит их на экран.

/*int[]array = GetArray(8);
Console.WriteLine($"[{String.Join(",", array) }]");


//-----------------------------Метод----------------------


int[] GetArray(int size) 

{

    int[] result = new int[size];
    for (int i = 0; i < size; i++)

    {

        result[i] =new Random().Next();
    }

    return result;
}*/


    







