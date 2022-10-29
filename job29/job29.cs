/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
пример из 5 элементов:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
получить все 8 чисел за одно нажатие Enter от пользователя.подсказка: использовать метод Split();
*/

int[] arr = new int[8];
void PrintArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,100);
        {
        Console.Write($"[{array[i]}] ");
        }
    }
    Console.WriteLine();
}
PrintArray(arr);