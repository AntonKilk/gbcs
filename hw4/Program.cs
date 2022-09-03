/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("===============");
Console.WriteLine("Power A in B times");
Console.WriteLine("Enter A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter B:");
int B = Convert.ToInt32(Console.ReadLine());
int Power(int A, int B) {
	int res = A;
	for (int i = 1; i < B; i++)
	{
		res *= A;
	}
	return (res);
}
Console.WriteLine(Power(A, B));

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("===============");
Console.WriteLine("Calculate sum of digits in number");
Console.WriteLine("Enter a number:");
int num = Convert.ToInt32(Console.ReadLine());
string str = num.ToString();
int[] result = str.Select(o => Convert.ToInt32(o) - 48).ToArray();
int sum = 0;
for (int i = 0; i < str.Length; i++)
{
	sum  += result[i];
}
Console.WriteLine(sum);

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("===============");
Console.WriteLine("Print array with 8 numbers");
int []array = new int[8];
for (int i = 0; i < 8; i++) {
	Console.WriteLine("Enter array element " + (i + 1) + ":");
	array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("[{0}]", string.Join(", ", array));
