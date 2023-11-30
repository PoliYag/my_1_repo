using System;

class Program
{
static void Main(string[] args)
{

int[] numbers = new int[10] { 10, 21, 14, 93, 23, 5, 30, 88, 10, 50 };



    int count = 0; 

    Console.Write("Массив [");
   
    foreach (int num in numbers)
    {
        Console.Write(num + " ");
        if (num >= 20 && num <= 90) 
        {
            count++;
        }
    }
    Console.Write("] => " + count); 
}
}