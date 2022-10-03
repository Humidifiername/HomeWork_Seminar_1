// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;

while (count < num)
{
    if (count % 2 == 0)
    {
        Console.Write(count + ", ");
    }
    count++;
}