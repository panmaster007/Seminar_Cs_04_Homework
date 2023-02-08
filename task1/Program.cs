int ReadInt1(string argument)
{
	Console.Write($"Введите {argument}: ");
	int number1;

	while (!int.TryParse(Console.ReadLine(), out number1))
	{
		Console.WriteLine("Error! Try again.");
	}

	return number1;
}

int ReadInt2(string argument)
{
	Console.Write($"Введите {argument}: ");
	int number2;

	while (!int.TryParse(Console.ReadLine(), out number2))
	{
		Console.WriteLine("Error! Try again.");
	}

	return number2;
}

int MatDegree(int number1, int number2)
{
	int i = 1;
   int result = number1; 
	while(i < number2)
	{
	result = result * number1;
	i++;
	}
	System.Console.WriteLine(result);

	return result;
}

MatDegree(ReadInt1("число которое нужно возвести в степень"), ReadInt2("степень в которую нужно возвести число"));