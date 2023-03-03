// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

Console.Clear();
Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = A;
int i = 1;
while( i < B)
    {
        result = result * A;
        i++;
    }
    
Console.WriteLine($"{A} в степени {B} равно {result}");
