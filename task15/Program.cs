// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Kakoj den` nedeli? ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 1 || a > 7)
{
    Console.WriteLine("are u stupid? ");
    a = Convert.ToInt32(Console.ReadLine());
}
if (a >= 1 && a <= 5) Console.WriteLine("net, ne vyhodnoj");
else Console.WriteLine("da, vyhodnoj");