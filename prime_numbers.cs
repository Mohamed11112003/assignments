using System;
namespace Task1
{
	public static class Program
	{
		public static void Main()
		{

            int X, Y, Z = 0;

            Console.WriteLine("First number:-");
             X = int.Parse(Console.ReadLine());

            Console.WriteLine("Second number:-");
             Y = int.Parse(Console.ReadLine());

 

            for (int i = 1; i < Y; i++)
            {
            for (int j = 1; j < Y; j++)
            {

                    if (i % j == 0)

                    {

                        Z++;

                    }

                }

                if (Z == 2)

                {

                    Console.WriteLine(i);

                }

                Z = 0;
            }

            

		}
	}
}

