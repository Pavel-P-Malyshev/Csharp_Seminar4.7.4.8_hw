/*
Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}


int Akkerman(int m, int n)
{
    if (m == 0 && n>=0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else if(m>0&&n>0)
    {
        return Akkerman(m - 1, Akkerman(m,n-1));
    }
   
   return -1;//возвращаем если аргументы отрицательные, чтобы не делать проверку
}



int m=Prompt("enter m: ");
int n=Prompt("enter n: ");
int result=Akkerman(m,n);
Console.WriteLine($"Akkerman function result for m={m} and n={n} is {result}");