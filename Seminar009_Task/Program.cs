int Number(int n)
{
    if(n > 1)
    {
        return 1 + Number(n / 10); 
    }
    return 0;
}

int ShowNNum(int m, int n)
{
    if(m <= n)
    {
        return m + ShowNNum(m+1, n);
    }
    return 0;
}
//Задача 64: Задайте значение N. Напишите программу, которая найдет 
//кол-во цифр в числе N рекурсивным методом.

/*Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(Number(n));*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.

/*Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(ShowNNum(m, n));*/