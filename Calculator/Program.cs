double num1, num2;
string? symb;

void calc()
{
	try
	{
		Console.WriteLine("Введите первое число: ");
		num1 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Введите второе число: ");
		num2 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Введите символ операции: ");
		symb = Convert.ToString(Console.ReadLine());
		if(num2 == 0 && symb == "/")
		{
			Console.WriteLine("Делить на 0 нельзя!");
			calc();

		}
		switch (symb)
		{
			case "+":
				Console.WriteLine(num1 + num2);
				break;
			case "-":
				Console.WriteLine(num1 - num2);
				break;
			case "*":
				Console.WriteLine(num1 * num2);
				break;
			case "/":
				Console.WriteLine(num1 / num2);
				break;
			default:
				Console.WriteLine("Вы ввели недопустимый символ операции");
				calc();
				break;

		}
	}
	catch
	{
		Console.WriteLine("Введенный параметр не является числом, либо выходит за допустимое значение.");
		calc();
	}
}
calc();


