/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.*/

/*int CutNumberSecond()
{
    Console.Write("Введите число от 100 до 999: ");
    int num = Convert.ToInt32(Console.ReadLine());

    int des = num / 10; //сколько десятков в числе (456->45)
    int ed = des % 10;  //отсечь остаток от деления на 10 (45->5)
    int result = ed;
    return result;
}
int number = CutNumberSecond();
Console.Write("Ваше число: " + number);*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного
 числа или сообщает, что третьей цифры нет.*/

/*void ThirdNumber()
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    
    if(num > 1000)
    {
        while(num > 1000)
        {
            num = num / 10;
        } 
    }  
    
    if(num > 99 && num < 1000)
    {
        int ed = num % 10;
        Console.WriteLine("Третья цифра:" + ed);
    }
    
    else
    {
       Console.WriteLine("Третьей цифры нет"); 
    }
}

ThirdNumber();*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/

void WeekNumber()
{
    Console.Write("Введите число недели: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num >=1 && num <=5)
    {
        Console.Write("Рабочий день");
    }
    if(num >= 6 && num <= 7)
    {
        Console.Write("Выходной день");
    }
    if(num >=8 )
    {
        Console.Write("ВВЕДИТЕ ЧИСЛО НЕДЕЛИ ОТ 1 ДО 7");
    }
}
WeekNumber();