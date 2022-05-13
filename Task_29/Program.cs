/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.Write("Введите числа через запятую: ");
string array = Console.ReadLine();
int index = 0;

while(index < array.Length)
{
    if(index == 0)
    {
        Console.Write("[" + array[0] + ", ");
    }
    else if(index == array.Length - 1)
    {
        Console.Write(array[array.Length-1] + "]");
    }
    else if(index > 0)
    {
        Console.Write(array[index] + ", ");
    }
    index += 2;

}
