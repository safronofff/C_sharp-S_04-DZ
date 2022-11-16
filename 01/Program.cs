//01-Решить задачи, используя МЕТОДЫ
//Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B (Math.Pow НЕ использовать)

//3, 5 -> 243 (3⁵)
//0, 0 - >1
//2, 4 -> 16

void StepenAB(int x, int y)
{
	int z = x;
	for (int i = 1; i < y; i++)
	{
		z = z * x;
	}
	Console.WriteLine($"A в степени B равно: {z}");

}

System.Console.WriteLine("Введите число A");
int num_1 = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите число B ");
int num_2 = Convert.ToInt32(System.Console.ReadLine());

StepenAB(num_1, num_2);
