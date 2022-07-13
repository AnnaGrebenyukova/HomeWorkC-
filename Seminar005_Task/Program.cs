
int[] RandomArray(int size) // генерируем массив из случайных трехзначных чисел
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100,1000);
    return newArray;
}

int[] Random2Array(int size, int min, int max) // генерируем массив из случайных трехзначных чисел заданных пользователем
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(min,max+1);
    return newArray;
}

double[] Random3Array(int size) // генерируем массив вещественных чисел
{
    double[] newArray = new double[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(1,1000) + new Random().NextDouble();
    return newArray;
}

double DifferenceNumbers(double[] array) //поиск минимального и максимольного и разницы между ними
{
    double max = array[0];
    double min = array[0];
    double result=0;
    
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i]; 
        if(array[i] < min) min = array[i];
        result = max - min;
    }
    return result;
}
     
int FindNumbers(int[] array) //метод считает количество четных чисел в массиве 
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) count++;
    return count;
}

int FindPosition(int[] array) // метод находит сумму элементов, стоящих на нечётных позициях
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(i %2 != 0) sum += array[i];
    return sum;
}

void ShowArray(int[] array)  //метод выводит массив на экран
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine();
}

void Show2Array(double[] array)  //метод выводит массив на экран
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine();
}

//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.

/*Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = RandomArray(size);
ShowArray(array);

Console.WriteLine("Количество четных элементов: " + FindNumbers(array));*/

//Задача 36: Задайте одномерный массив, заполненный случайными 
//числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = Random2Array(size, min, max);
ShowArray(array);

Console.WriteLine("Сумма элементов на нечетных позициях: " + FindPosition(array));*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу 
//между максимальным и минимальным элементов массива.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = Random3Array(size);
Show2Array(array);

Console.WriteLine("Разница между max и min: " + DifferenceNumbers(array));