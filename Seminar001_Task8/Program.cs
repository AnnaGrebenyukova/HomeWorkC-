int n, current;
Console.WriteLine("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());
current = 2;
while (current <= n)
if (current%2 == 0)
{
    Console.Write(current + " ");
    current = current + 2;
}