/* Напишите программу вычисления 
функции Аккермана с помощью рекурсии.*/

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

int Akkerman(int a, int b) 
{
    if(a == 0)
        {return b+1;} 
        else if (a != 0 && b == 0)
                 {return Akkerman(a-1,1);}
                 else {return Akkerman(a-1,Akkerman(a,b - 1));}
}

int n = ReadInt("Введите Число N");
int m = ReadInt("Введите Число M");

Console.WriteLine($" Функция Аккермана равна {Akkerman(n,m)}");