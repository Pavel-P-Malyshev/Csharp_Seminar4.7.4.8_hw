/*
Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}


int RangeSum (int min, int max)
{
    if(min>max){
        return 0;
    } 
    
    return RangeSum(min, max-1)+max;
    
} 
   


int n=Prompt("enter N: ");
int m=Prompt("enter m;");
int result=RangeSum(n,m);
Console.WriteLine($"sum is {result}");