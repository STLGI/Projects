double num1, num2;
string? symb;

while (true) { 
	try
	{

		bool ZeroCheck(double num, string? symb)
		{
			if(num == 0 && symb == "/")
			{
				return true;
			}
			return false;
		}

		bool Calc(double num1, double num2, string? symb)
		{
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
					return true;

            }
			return false;
        }

		Console.WriteLine("Введите первое число: ");
		num1 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Введите второе число: ");
		num2 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Введите символ операции: ");
		symb = Convert.ToString(Console.ReadLine());
		if(ZeroCheck(num2, symb))
		{
			Console.WriteLine("Делить на 0 нельзя!");
			continue;

		}
		if(Calc(num1, num2, symb))
		{
			continue;
		}
		break;
	}
	catch
	{
		Console.WriteLine("Введенный параметр не является числом, либо выходит за допустимое значение.");
		continue;
	}
}



