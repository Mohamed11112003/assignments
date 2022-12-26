using System;

namespace Task_2
{
	public static class Program
	{
		public static void Main()
		{
int X, Y; 
            Console.WriteLine("Enter Starting Number : ");  
            X = int.Parse(Console.ReadLine());  
            Console.WriteLine("Enter Ending Number : ");  
            Y = int.Parse(Console.ReadLine());  
  
            Console.WriteLine("perfect numbers between " + X + " and " + Y);  
               
            for (int i = X; i <= Y; i++)  
            {  
                int sum = 0;  
                for (int j = 1; j < i; j++)  
                {  
                    if (i % j == 0)  
                        sum = sum + j;  
                }  
                if (sum == i)  
                    Console.WriteLine( +i);  
           }  
  
            
        }  
     }  
  
  }
