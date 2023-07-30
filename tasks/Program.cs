using System;
using MyLib;

namespace tasks;
class Program
{
    static void Main(string[] args)
    {
        void Task47()
        {
            int rows = 3;
            int columns = 4;
            double[,] numbers = new double[rows, columns];

            MyLib.MyLibClass.FillArray(numbers);
            MyLib.MyLibClass.PrintArray(numbers);
        }

        void Task50()
        {
            int rows = 3;
            int columns = 4;
            int[,] numbers = new int[rows, columns];

            MyLib.MyLibClass.FillArray(numbers, 1, 10);
            MyLib.MyLibClass.PrintArray(numbers);

            int inputRows = MyLib.MyLibClass.Input("Введите индекс строки: ");
            int inputColumns = MyLib.MyLibClass.Input("Введите индекс столбца: ");

            if (inputRows >= 0 && inputRows < rows
                 && inputColumns >= 0 && inputColumns < columns)
            {
                Console.WriteLine($"Элемент = {numbers[inputRows, inputColumns]}");
            }
            else
            {
                Console.WriteLine("Такого элемента нет");
            }
        }

        void Task52()
        {
            int rows = 3;
            int columns = 4;
            int[,] numbers = new int[rows, columns];

            MyLib.MyLibClass.FillArray(numbers, 1, 10);
            MyLib.MyLibClass.PrintArray(numbers);

            double sum = 0;
            
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    sum += numbers[i, j];
                }

                double arithmeticMean = Math.Round(sum / rows, 2);

                Console.WriteLine($"Среднее арифметическое столбца {j + 1}: {arithmeticMean}");
            }
        }


        // Проверка кода. 
        Console.Clear();
        int task = MyLib.MyLibClass.Input("Введите номер задачи: ");
        switch (task)
        {
            case 47:
                Task47();
                break;
            case 50:
                Task50();
                break;
            case 52:
                Task52();
                break;
            default:
                Console.WriteLine("Ошибка ввода");
                break;
        }
    }
}