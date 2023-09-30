//Функция перезаписи массива
void ArrFill(long num, ref bool[] arr)
{
    for (long i = 2; i <= num; i++)
    {
        if (i < 1)
        {
            i = 0;
            continue;
        }
        arr[i - 1] = true;
    }
}

//Функция перезаписи массива
void ArrRewr(long num1, long num2, ref bool[] arr, ref int count)
{
    for (long i = 2; i <= num2; i++)
    {
        if (arr[i - 1] == true)
        {
            for (long j = i * i; j <= num2; j += i)
            {
                if (j >= num1 && j <= num2 && arr[j - 1] != false)
                {
                    count++;
                }
                    arr[j - 1] = false;
                
            }
        }
    }
}
//Функция вывода массива

void ArrWrite(long num1, long num2, bool[] arr)
{
    for (long i = num1; i <= num2; i++)
    {

        if (i < 1)
        {
            i = 0;
            continue;
        }
        if (arr[i - 1] == true)
        {
            Console.WriteLine(i);
        }
    }
}
while (true) {
	try
	{
		//Задаем значения

		long num1, num2;
		int count = 0;
		Console.WriteLine("Введите начало диапазона: ");
		num1 = Convert.ToInt64(Console.ReadLine());
		Console.WriteLine("Введите конец диапазона: ");
		num2 = Convert.ToInt64(Console.ReadLine());

		//Исключения

		if (num2 <= 1 || num1 == num2)
		{
			Console.WriteLine("В заданном диапазоне нет простых чисел.");
			Environment.Exit(0);
		}

		bool[] array = new bool[num2];

		//Заполняем массив

		ArrFill(num2, ref array);

		//Переписываем массив

		ArrRewr(num1, num2, ref array, ref count);

		//Проверка на наличие простых чисел

		if (count - 1 == num2 - num1)
		{
			Console.WriteLine("В заданном диапазоне нет простых чисел.");
			Environment.Exit(0);
		}
		//Вывод массива

		Console.WriteLine("Простые числа в заданом диапазоне: ");
        ArrWrite(num1, num2, array);

		break;
	}
	catch
	{
		Console.WriteLine("Введенное значение не является числом, либо выходит за возможный диапазон.");
		continue;
	}
}
