//Задача 27: Напишите программу, которая 
//принимает на вход число и выдаёт сумму цифр в числе.

/*int SumNumbers(int a)
{
    int sum = 0;
    int current = 0; //счетчик количества цифр в числе
    if(current <= a)
    {
        while(a > 0) //пока число не сравняется с 0
        {
            sum = sum + a % 10; // к сумме прибавляем остаток от деления на 10
            a = a / 10; // от числа отсекаем по одному разряду (123->12)
            current++; // увеличиваем счетчик на 1
        }
    }
    return sum; // возврат значения из метода
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int num = SumNumbers(a);
Console.Write("Сумма чисел: " + num);*/


//Задача 29: Напишите программу, которая задаёт 
//массив из m элементов и выводит их на экран.

int[] NewArray(int m)
{
    int[] newArray = new int[m]; //инициализирует новый массив из m элементов
    for(int i= 0; i < m; i++)
        newArray[i] = new Random().Next(-5, 5); //пока индекс меньше m создаем элементы массива в диапазоне (от-5 до 5)
    return newArray;

}

void ShowNewArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] +" ");
    Console.WriteLine();
}

Console.Write("input size of array: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = NewArray(m);
ShowNewArray(array);