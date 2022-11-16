//02-Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

int SummaCifir(int x)
{
	int y = 0;
	while (x > 0)
	{
		int z = x % 10;
		x = x / 10;
		y = y + z;
	}
	return y;
}

Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());

int result = SummaCifir(num);
Console.WriteLine($"сумма всех цифр в числе {num} равна: {result}");