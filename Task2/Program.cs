/*Задайте значения M и N.Напишите программу, 
которая найдет сумму натуральных элементов 
в промежутке от М до N.*/

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

int SumNaturalNumbers(int a, int b) 
{
    int Sum = a;
    if (a > b)
    {
        Sum = Sum + SumNaturalNumbers(a -1, b);
    }
    return Sum;
}

int n = ReadInt("Введите Число N");
int m = ReadInt("Введите Число M");
int s = 0;
if (n > m ) { s = SumNaturalNumbers(n,m);}
    else { s = SumNaturalNumbers(m,n);}
Console.WriteLine(s);