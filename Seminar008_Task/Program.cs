
int[,] CreateRandomArray(int rows, int columns) //генерируем массив
{
    int[,] myArray = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            myArray[i,j] = new Random().Next(0, 10);
        }
    }
    return myArray;
}

void ShowArray(int[,] array)  //выводим массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ReverseOrderArray(int[,] array) // разворачиваем элементы по рангу
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int a = 0; a < array.GetLength(1) - 1; a++)
            {
                if (array[i,a] < array[i,a+1]) //чтобы изменить сортировку, нужно поменять знак < на >
                {
                    int temp = array[i,a];
                    array[i,a] = array[i,a+1];
                    array[i,a+1] = temp;
                }
            }
        }
    }
    return array;
}

void FindMinSumRows(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
    {
        int count = 0;
        int minSum = Int32.MaxValue;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            { 
                sum = sum + array[i,j];
            }
        
            if (sum < minSum) 
            {
                minSum = sum; 
                count++; 
            } 
            
        }
        Console.Write($"{count}");
    }
    else Console.WriteLine("Массив не квадратный");
    
}

int[,] QuardArray(int n)
{
    int[,] array = new int[n, n];
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
        temp++;
    }
    return array;
}

//Задача 54: Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.

/*Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(rows,columns);
ShowArray(myArray);
Console.WriteLine();
int[,] newArray = ReverseOrderArray(myArray);
ShowArray(newArray);*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

/*Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(rows,columns);
ShowArray(myArray);

FindMinSumRows(myArray);*/

//Задача 62. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:

//1  2  3  4
//12 13 14 5
//11 16 15 6
//10 9  8  7

Console.Write("Введите количество n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = QuardArray(n);
ShowArray(myArray);