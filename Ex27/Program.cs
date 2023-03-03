// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

Console.Clear();
Console.Write("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int num = 0;

while(i > 0)
    {
        num = i % 10;
        sum = sum + num;
        i = i / 10;
    }
Console.WriteLine($"сумма цифр в числе равна: {sum}");
