//Задача 19 Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.

/*void Palindrom()
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    int five = num / 10000;
    int one = num % 10;
    
    int four1 = num / 1000;
    int four = four1 % 10;

    int two1 = num % 100;
    int two = two1 / 10;

    if(five == one && four == two)
    {
        Console.WriteLine("Ваше число - палиндром");
    }
    else
    {
        Console.WriteLine("Ваше число не является палиндромом");
    }
}
Palindrom();*/

//Задача 23 Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

void ShowCube(int n)
{
    int current = 1;

    while(current <= n)
    {
        int cube = current * current * current;
        Console.Write(cube + " ");
        current++;
    }
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

ShowCube(number);