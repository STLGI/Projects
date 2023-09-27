void primeNum()
{
	try
	{
		long num1, num2;
		int count = 0;
		Console.WriteLine("Введите начало диапазона: ");
		num1 = Convert.ToInt64(Console.ReadLine());
		Console.WriteLine("Введите конец диапазона: ");
		num2 = Convert.ToInt64(Console.ReadLine());
		if (num2 <= 1 || num1 == num2)
		{
			Console.WriteLine("В заданном диапазоне нет простых чисел.");
			Environment.Exit(0);
		}
		bool[] array = new bool[num2];

		for (long i = 2; i <= num2; i++)
		{
			if (i < 1)
			{
				i = 0;
				continue;
			}
			array[i - 1] = true;
		}

		for (long i = 2; i <= num2; i++)
		{
			if (array[i - 1] == true)
			{
				for (long j = i * i; j <= num2; j += i)
				{
					array[j - 1] = false;
					if (j >= num1 && j <= num2)
					{
						count++;
					}
				}
			}
		}
		if (count - 1 == num2 - num1)
		{
			Console.WriteLine("В заданном диапазоне нет простых чисел.");
			Environment.Exit(0);
		}
		Console.WriteLine("Простые числа в заданом диапазоне: ");
		for (long i = num1; i <= num2; i++)
		{

			if (i < 1)
			{
				i = 0;
				continue;
			}
			if (array[i - 1] == true)
			{
				Console.WriteLine(i);
			}
		}
	}
	catch
	{
		Console.WriteLine("Введенное значение не является числом, либо выходит за возможный диапазон.");
		primeNum();
	}
}
primeNum();