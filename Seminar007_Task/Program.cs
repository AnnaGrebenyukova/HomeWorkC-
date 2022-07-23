double[,] CreateArray(int rows, int columns, int minValue, int maxValue) //метод по генерации массива со случайными вещественными числами
{
    double[,] newArray = new double[rows,columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
        newArray[i,j] = new Random().Next(minValue,maxValue+1) + new Random().NextDouble();
    return newArray;
}

int[,] CreateRandomArray(int rows, int columns) //метод по генерации массива со случайными целыми числами
{
    int[,] newArray = new int[rows,columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(0,10);
    return newArray;
}

void ShowArray(double[,] array) // метод печати двумерного массива с вещественными числами
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }   
}
void Show2Array(int[,] array) // метод печати двумерного массива с целыми числами
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }   
}

void FindNumber(int[,] array, int i, int j)  //метод по поиску элемента по заданному индексу
{
    if (i > array.GetLength(0) || j > array.GetLength(1))
        Console.WriteLine("Элемента с заданным индексом нет");
    else
        Console.WriteLine($"Значение элемента {i} строки и {j} столбца равно {array[i,j]}");
    
}

void FindSaNumber(int[,] array) //метод по поиску среднего арифметического по столбцам, поискать решение через int
{
    int n = array.GetLength(0); //количество строк
    for(int j = 0; j < array.GetLength(1); j++)
    { 
        double average = 0; // при прохождении по столбцу, перед следующим столбцом обнуляет результат
        for(int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i,j];
        }
        average = average / n;
        Console.Write(average + "; ");
    } 
}

//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
/*Console.Write("Imput number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateArray(m,n,min,max); //запрос массива
ShowArray(myArray);*/ //показать массив, найти возможность вывода с одной цифрой после запятой

//Задача 50. Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает значение этого 
//элемента или же указание, что такого элемента нет.

/*Console.Write("Imput number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(m,n);
Show2Array(myArray); // показали массив

Console.WriteLine("Введите номер строки: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int j = Convert.ToInt32(Console.ReadLine());
FindNumber(myArray, i, j);*/ //запрос метода по поиску элемента

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Imput number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(m,n);
Show2Array(myArray); // показали массив

FindSaNumber(myArray);