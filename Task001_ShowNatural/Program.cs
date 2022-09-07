/*
Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue=Console.ReadLine();
    return int.Parse(readValue);
}


void ShowEvenNaturalRange(int min, int max)
{
    if(min>max){
        return;
    } 
    
    ShowEvenNaturalRange(min, max-1);
    if(max%2==0) Console.WriteLine(max);
} 
   


int n=Prompt("enter N: ");
int m=Prompt("enter m;");
ShowEvenNaturalRange(n,m);