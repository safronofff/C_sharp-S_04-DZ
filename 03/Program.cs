//03-Задача 29: Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] CreatRandArray(int x, int minVal, int maxVal)
{
	int[] arr = new int[x];
	for (int i = 0; i < x; i++)
	{
		arr[i] = new Random().Next(minVal, maxVal);
	}
	return arr;
}

void PrintArray(int[] arr)
{
	System.Console.Write("[");
	for (int i = 0; i < arr.Length; i++)
	{
		System.Console.Write($"{arr[i]}, ");
	}
	System.Console.Write("\b\b]");
}

System.Console.WriteLine("Введите число , определяющее длинну массива ");
int num_1 = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите число , определяющее минимальный эдемент в массиве ");
int num_2 = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Введите число , определяющее максимальный эдемент в массиве ");
int num_3 = Convert.ToInt32(System.Console.ReadLine());

PrintArray(CreatRandArray(num_1, num_2, num_3));