/*Задайте значение N. Напишите программу, 
которая выведет все натуральные числа от N до 1. 
Выполнить с помощью рекурсии.*/

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

void NaturalNumbers(int a) 
{
if (a > 0)
{
    Console.Write($"  {a} ");
    NaturalNumbers(a-1);
}

}

int n = ReadInt("Введите Число N");

NaturalNumbers(n);
Console.WriteLine();