//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите число больше 99 ");

int myNum = int.Parse(Console.ReadLine());

if (myNum > 1000)
{
    
}
if(myNum < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    int thirdNum = myNum % 10;
    System.Console.WriteLine(thirdNum);
}
