//однострочный комментарий
/*ghjksjhgvvbdhvdkvdhjvdhvdhvdkhjvdjhvdhjjjdhvdvhdsvh
dgdgdjgekjghleiulgyhwjghrghrghge
desgdfghdfhgjhgfjfgjgf*/


//ctrl+/

//Напишитепрограмму которая на вход принимает2 числа и проверяет,является ли первое число кважратом  второго
/*
Console. WriteLine ("Введи первое число");
int Num1 = int. Parse (Console.ReadLine ()!);
Console. WriteLine ("Введи второе число");
int Num2 = int. Parse (Console.ReadLine ()!);

if(Math.Pow(Num2, 2)== Num1){
     Console. WriteLine ("Первое число является квадратом второго !");
}
else{
     Console. WriteLine ("Первое число не является квадратом второго !");
}
*/
/* 
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine ()!);

int b = a*a;

Console.WriteLine("Квадрат заданного числа -" + b);  */

//задача 6

/*
Console.WriteLine("Введите число");
int i = int.Parse(Console.ReadLine()!);

if(i%2 ==0){

     Console.WriteLine("Введённое число является чётным");
}
else{

     Console.WriteLine("Введённое число является нечётным");
}*/

//Задача № 8
/*
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int i = 1;

while(i<= N)

if(i %2 ==0)
{
     Console.WriteLine($"{i}, ");

     i++;
}
else{

     i++;
}*/
//Задача 2
/*
Console.WriteLine("Введите прервое число");
int Num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int Num2 = int.Parse(Console.ReadLine()!);
 master
if(Num1<Num2){

     Console.WriteLine("Первое число меньше второго числа");
}
else{

     Console.WriteLine("Первое число больше второго числа");
}*/

//Задача 4
/*
Console.WriteLine("введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите второе число");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine()!);

if(a>b){

     Console.WriteLine("Первое число максимальное");
}
else{

     Console.WriteLine("второе число максимальное");
}

if(b>c){

     Console.WriteLine("Второе число максимальное");

}
else{

     Console.WriteLine("Третье число максимальное");
}

if(c>a){

     Console.WriteLine("Третье число максимальное");
}

else{
     Console.WriteLine("Первое число максимальное");
}
*/









//Домашнее задание  Семинар 2
//Задача 10


//Напишите прогрпмму,которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру  1этого числа.
//Обязательна проверка на ввод чисел больше/меньше трёх .

//456 -> 5
//782 -> 8
//918 -> 1



//int n = new Random(). Next(100, 1000);
/*int n = 918;
int t = (n % 100) / 10;
Console.WriteLine(n);
Console.WriteLine(t);*/
//___________________________________________________________________


/*Задача 13

Напишите программу,которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет. Берём числа до 100000.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


//int c = new Random(). Next(1, 100000);
/*int c = 78;
int s = (c % 1000) /100;
Console.WriteLine(c);
if (s > 0){

     Console.WriteLine(s);
}
else{

     Console.WriteLine("Нет числа");
}
*/
//________________________________________________________________


/*Задача 15

Напишите программу,которая принимает на вход цифру,обозначающую день недели,
и проверяет,является ли этот день выходным.
Обязательна проверка на ввод числа <1 и >8.

6 -> да
7 -> да
1 -> нет
*/

/*Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);

if(num < 1 || num > 7)
{
     Console.WriteLine("В неделе 7 дней! Введено неверное числою");

}
else
{
     if(num == 6 || num == 7)
     {
          Console.WriteLine("Это выходной");
     
     }
     else if(num >= 1 || num <= 5)
     {
          Console.WriteLine("Это будний день");
     }
}
*/