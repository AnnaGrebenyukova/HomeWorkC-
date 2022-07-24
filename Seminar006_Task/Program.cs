//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//НЕ ПОЙМУ ПОЧЕМУ ТАК ---> РАБОТАЕТ??

/*Console.Write($"Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int FindNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(m);

Console.WriteLine($"Количество элементов больше 0: {FindNumber(array)} ");*/

//ТАК (НИЖЕ) НЕ РАБОТАЕТ??? подскажите ПОЖАЛУЙСТА

/*void InputNumbers(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int FindNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count += 1;
    }
    return count;
}

Console.Write($"Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
InputNumbers(m);
Console.WriteLine($"Количество элементов больше 0: {FindNumber(array)} ");*/

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем. */

void FindCoordinates(double b1, double k1, double b2, double k2)
{
    if(k1 == k2 && b1 != b2)
    {
        Console.WriteLine($"Две прямые параллельны");
    }
    else
    {
        double x = (-b2 + b1)/(-k1 + k2);
        double y = k2 * x + b2;
        Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
    }
}
   
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

FindCoordinates(b1, k1, b2, k2);