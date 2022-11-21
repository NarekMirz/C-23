// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.WriteLine("Введите число для недели ");

int dayNum = int.Parse(Console.ReadLine());

if(dayNum == 6 || dayNum == 7)
{
    System.Console.WriteLine("Этот день выходной ");
}
else if(dayNum > 1 || dayNum <6)
{
    System.Console.WriteLine("Этот день не выходной");
}

else if(dayNum < 1 || dayNum > 7)
{
    System.Console.WriteLine("Введите число от 1 до 7 ");
}