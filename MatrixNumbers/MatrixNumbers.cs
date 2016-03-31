using System;

class MatrixNumbers
{
    static void Main(string[] args)
    {
        int n;
        Console.Write("Enter positive number: ");
        n = int.Parse(Console.ReadLine());
        int temp;
        for (int i = 1; i <= n; i++)
        {
            temp = i;
            for (int j = 1; j <= n; j++)
            {
                Console.Write(temp + " ");
                temp++;
            }
            Console.WriteLine("");
        }
    }
}
