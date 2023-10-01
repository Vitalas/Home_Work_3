// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = number * -1;

int SumDigit(int num)
{
    int sumDigit = 0;
    for (int i = 0; num != 0; i++)
    {
        sumDigit = sumDigit + (num % 10);
        num = num / 10;
    }
    return sumDigit;
}

Console.WriteLine($"{number} -> {SumDigit(number)}");
