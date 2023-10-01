// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A : ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B : ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0) numberB = numberB * -1;

int PowerA(int num)
{

    int powerA = numberA;

    for (int i = 1; i < numberB; i++)
    {
        checked
        {
            powerA = numberA * powerA;
        }

    }
    return powerA;
}
Console.WriteLine($"{numberA}, {numberB} -> {PowerA(numberA)}");