using MyLib;
namespace Task;

class Program
{
    static void Main(string[] args)
    {
        void Task54()
        {
            // Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
            int rows = MyLibClass.Input("Введите количество строк:");
            int columns = MyLibClass.Input("Введите количество столбцоы:");
            int[,] matrix = new int [rows,columns];
            MyLibClass.FillArray(matrix);
            Console.WriteLine("Исходный массив");
            MyLibClass.PrintArray(matrix);
            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);
            for (int i =0; i < rowCount; i++ )
            {
                for(int j =0; j < colCount -1; j++)
                {
                    for(int k = 0; k < colCount -j -1; k++)
                    {
                        if(matrix[i,k] <  matrix[i,k+1])
                        {
                            int temp = matrix[i,k];
                            matrix[i,k] = matrix[i,k+1];
                            matrix[i, k+1] = temp;
                        }

                    }
                    
                }
            }
            Console.WriteLine("Массив после сортировки:");
            MyLibClass.PrintArray(matrix);
            
        }

        void Task56()
        {
            //Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
            int rows = MyLibClass.Input("Введите количество строк:");
            int columns = MyLibClass.Input("Введите количество столбцоы:");
            int[,] matrix = new int [rows,columns];
            MyLibClass.FillArray(matrix,1,9);
            MyLibClass.PrintArray(matrix);
            int rowCount = matrix.GetLength(0);
            int colCount = matrix.GetLength(1);
            int minSum = int.MaxValue; 
            int minRowSum = 0; //для хранения строки с наименьшей суммой элементов 
            for (int i = 0; i < rowCount; i++ )
            {
                int currentSum = 0; // для хранения суммы элементов текущей строки, перед циклом j , чтобы обнулалась при переходе на новую строку
                for(int j =0; j < colCount; j++)
                {
                    currentSum +=matrix[i,j];
                }
                if(currentSum < minSum)
                {
                    currentSum = minSum;
                    minRowSum = i;
                    
                }

            }
            Console.WriteLine($"строка с наименьшей суммой элементов  {minRowSum + 1}"); // +1 номер строки для пользователя 
           
        }
        void Task58()
        {
            // Заполните спирально массив 4 на 4 числами от 1 до 16.
            int n =4;
            int[,] matrix = new int [n,n];
            int currentNumber = 1; // для хранения текущего числа 
            int topRow = 0, bottomRow = n - 1, leftCol = 0, rightCol = n - 1; //определяем границы
            while(currentNumber <= n*n)
            {
                 // Заполняем верхнюю границу слева направо
                for (int i = leftCol; i <= rightCol; i++)
                {
                    matrix[topRow, i] = currentNumber;
                    currentNumber++;
                }
                topRow++;
                 // Заполняем правую границу сверху вниз
                for (int i = topRow; i <= bottomRow; i++)
                {
                    matrix[i, rightCol] = currentNumber;
                    currentNumber++;
                }
                rightCol--;
                // Заполняем нижнюю границу справа налево
                for (int i = rightCol; i >= leftCol; i--)
                {
                    matrix[bottomRow, i] = currentNumber;
                    currentNumber++;
                }
                bottomRow--;
                // Заполняем левую границу снизу вверх
                for (int i = bottomRow; i >= topRow; i--)
                {
                    matrix[i, leftCol] = currentNumber;
                    currentNumber++;
                }
                leftCol++;
            }
            MyLibClass.PrintArray(matrix);

        }
        Task58();
    }
}
