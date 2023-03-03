// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

int RaiseToPower(int A, int B)
{
    int i = 1;
    int result = A;
    while (i < B)
    {
        result = result * A;
        i++;
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{A} в степени {B} равно {RaiseToPower(A, B)}");
