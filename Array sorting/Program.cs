using System.Linq.Expressions;

long amount, pos = 0, check = 0;
string? input;

//Функция заполнения массива
void Fill(long amount, string? input, ref long[] array, ref long check)
{
    string perm = "";
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ' ')
        {
            perm += input[i];

        }
        else
        {
            if(perm == "") { continue; }
			array[pos] = Convert.ToInt64(perm);
            pos++;
            perm = "";
            check++;
        }
    }
	if (perm != "")
	{
		array[pos] = Convert.ToInt64(perm);
	}

}


//Функция сортировки массива
void Sort(long amount, ref long[] array)
{
    long num;
    for (int i = 0; i < amount; i++)
    {
        for (int j = 0; j < amount - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                num = array[j];
                array[j] = array[j + 1];
                array[j + 1] = num;
            }

        }
    }

}


//Фонкция вывода массива
void Out(long amount, long[] array)
{
    for (int i = 0; i < amount; i++)
    {
        Console.WriteLine(array[i]);
    }
}

while (true) { 
	try
	{


        //Получаем количество элементов массива

        Console.WriteLine("Введите количество элементов массива: ");
		amount = Convert.ToInt64(Console.ReadLine());

		//Проверка на количество элементов массива

		if (amount <= 0)
		{
			Console.WriteLine("Введенное количество элементов массива должно быть больше 0. \n");
			continue;

		}
		long[] array = new long[amount];

		//Записываем массив чисел

		Console.WriteLine("Введите массив чисел через пробел: ");
		input = Console.ReadLine();

		Fill(amount, input, ref array, ref check);
	

		//Проверка на количество введенных элементов(если меньше)

		if(check != amount)
		{
			Console.WriteLine("Вы ввели слишком мало элементов. \n");
			continue;
		}

		//Сортируем массив

		Sort(amount, ref array);

		//Выводим массив
		Console.WriteLine("Отсортированный массив: ");
		Out(amount, array);
		break;
	}

	catch (System.IndexOutOfRangeException)
	{
		Console.WriteLine("Вы ввели слишком много элементов.\n");
		continue;
	}
	catch (System.FormatException)
	{
		Console.WriteLine("Введенное вами значение не является числом. \n");
		continue;
	}


}
