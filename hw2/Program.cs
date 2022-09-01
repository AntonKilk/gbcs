/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 */
Console.WriteLine("===============");
Console.WriteLine("Show 2nd digit");
Console.WriteLine("Enter 3-digit number:");
int nb = Convert.ToInt32(Console.ReadLine());
if (nb > 999 || nb < 100)
	Console.WriteLine("Wrong input");
else {
	nb = nb / 10;
	int result = nb % 10;
	Console.WriteLine(result);
}

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/
Console.WriteLine("===============");
Console.WriteLine("Show third digit if exists");
Console.WriteLine("Enter a number:");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100)
	Console.WriteLine("No 3rd digit in that number");
else {
	while (a > 999)
		a /= 10;
	Console.WriteLine(a % 10);
}

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/
Console.WriteLine("===============");
Console.WriteLine("Check if weekend");
Console.WriteLine("Enter a weekday number between 1 and 7");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 || day > 7)
	Console.WriteLine("Wrong input");
else if (day == 6 || day == 7)
	Console.WriteLine("Yes");
else
	Console.WriteLine("No");
