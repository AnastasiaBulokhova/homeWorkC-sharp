// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter number : ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;
int count = 1;
int result = 0;

if (num > 99)
{

    while (num1 > 10)
    {
        num1 = num1 / 10;
        count++;
    }

    while (count > 3)
    {
        num = num / 10;
        count--;
    }
    result = num % 10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Нет третьей цифры");
}












/*if(num > 999)
{
    int num2 = num / 10 % 10; //1555 - 155
    Console.WriteLine(res);
}
else if(num > 99 && num < 1000)
{
    int num1 = num % 10; // 254 - 4
    Console.WriteLine(num1);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}*/

