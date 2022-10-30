/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/*
int FindSecondNum (int num)
{
    int num1 = num % 100;
    int num2 = num1 / 10;
    {
        return num2;
    }
}

int RandomNumber = new Random().Next(101,998);
int result = FindSecondNum(RandomNumber);
Console.WriteLine($"Рандомное число {RandomNumber} вторая цифра из рандомного чиал {result}");
*/



/*
Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


Console.WriteLine("Ввведите число");
int num = Convert.ToInt32(Console.ReadLine());
while (num>1000)
{
    num = num/10;
}

int Sum = num % 10;
if (Sum == 0)
Console.WriteLine($"У числа нет 3 цифры");
else Console.WriteLine($"Третья цифра чиал - {Sum}");


/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
/*
Console.WriteLine("Ввведите день недели в виде цифры от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
int maximum = 5;
if (num <= maximum)
Console.WriteLine($" {num} -> рабочий день");
else Console.WriteLine($" {num} -> выходной день");
*/

/*
void NumberOfWeek(int num)
{
    if (num > 5)
    {
        Console.WriteLine($"{num}-> weekend");
    }
    else Console.WriteLine($"{num}-> workday");
}
Console.WriteLine("Ввведите день недели в виде цифры от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
NumberOfWeek(num);
*/