/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Write("Введите отличное от 1 целое число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberN > 1)
{
    int evenNumber = 2;
    while (evenNumber <= numberN)
    {
        Console.Write(evenNumber + "  ");
        evenNumber +=2;        
    }
}

if (numberN < 1)
{
    int evenNumber = 0;
    while (evenNumber >= numberN)
    {
        Console.Write(evenNumber + "  ");
        evenNumber +=-2;        
    }
}
