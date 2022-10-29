/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Например:
452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber(string message) 
{
    int digit;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out int number) && number > 0)
        {
            digit = number;
            break;
        }
        else
        {
            Console.WriteLine($"{number} - Введены не корректные данные. Повторите ввод \n");
        }
    }
    return digit;
} 

int numberConstant = GetNumber("Введите натуральное число: ");
int number = numberConstant;
int sum = 0;
int changes;

while(number != 0)
{
    changes = number % 10;
    number = number /10;
    sum += changes;    
}
Console.WriteLine($"Сумма чисел в натуральном чиселе {numberConstant} равняется {sum}");






/*var digit = number.ToString().Select(t=>int.Parse(t.ToString())).ToArray();*/

