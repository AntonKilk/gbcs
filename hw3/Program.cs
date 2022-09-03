
/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 */

Console.WriteLine("===============");
Console.WriteLine("Check if palindrome");
Console.WriteLine("Enter 5-digit number:");
int nb = Convert.ToInt32(Console.ReadLine());
if (nb > 99999 || nb < 10000)
	Console.WriteLine("Wrong input");
else {
	bool Palindrome(int nb) {
		string myString = nb.ToString();
		return myString.SequenceEqual(myString.Reverse());
	}
	if (Palindrome(nb))
		Console.WriteLine("Yes");
	else
		Console.WriteLine("No");
}

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("===============");
Console.WriteLine("Calculate distance between points in 3D");

int []arr = new int[6];
for(int i = 0; i < 6; i++)
{
	if (i < 3)
		Console.WriteLine("Enter " + (i + 1) + " coordinate of the first point:");
	else
		Console.WriteLine("Enter " + (i - 2) + " coordinate of the second point:");
	arr[i] = Convert.ToInt32(Console.ReadLine());
}
double distance = Math.Sqrt((Math.Pow(arr[0] - arr[3], 2)
	+ Math.Pow(arr[1] - arr[4], 2)
	+ Math.Pow(arr[2] - arr[5], 2)));
Console.WriteLine(distance);

/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("===============");
Console.WriteLine("Find cubes for all numbers in range 1...N");
Console.WriteLine("Enter a reasonably small number:");
int N = Convert.ToInt32(Console.ReadLine());
int []cubes = new int[N];
for (int i = 1; i <= N; i++)
	cubes[i - 1] = (int)Math.Pow(i, 3);
Console.WriteLine("{0}", string.Join(", ", cubes));
