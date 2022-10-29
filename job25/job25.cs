/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Например:
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetNumberA(string message) 
{
    int digit;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out int numberA) && numberA > 0)
        {
            digit = numberA;
            break;
        }
        else
        {
            Console.WriteLine($"{numberA} - Введены не корректные данные. Повторите ввод \n");
        }
    }
    return digit;
} 

int GetNumberB(string message) 
{
    int digit;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out int numberB) && numberB > 0)
        {
            digit = numberB;
            break;
        }
        else
        {
            Console.WriteLine($"{numberB} - Введены не корректные данные. Повторите ввод \n");
        }
    }
    return digit;
} 

int numberA = GetNumberA("Введите натуральное число А: ");
int numberB = GetNumberB("Введите натуральное число B: ");
double degree = Math.Pow(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равняется {degree}");