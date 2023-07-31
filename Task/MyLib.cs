namespace MyLib;

class MyLibClass
{
    public static void FillArray(double[,] matrix, int minValue = -9, int maxValue = 9)
    {
        maxValue++;
        Random rnd = new Random();
        for(int i =0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = rnd.NextDouble();
                matrix [i,j] = Math.Round(matrix[i,j],1);
            }
        }
    }

    public static void FillArray(int[,] matrix, int minValue = -9, int maxValue = 9)
    {
        maxValue++;
        Random rnd = new Random();
        for(int i =0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = rnd.Next(minValue,maxValue);  
            }
        }
    }


    public static void PrintArray(double[,] matrix)
    {
        for(int i =0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i,j]}\t  ");
            }
            Console.WriteLine();
        }
           
    }

    public static void PrintArray(int[,] matrix)
    {
        for(int i =0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i,j]}\t  ");
            }
            Console.WriteLine();
        }
    }
           

    public static int Input(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }


}


