int ReadInt(string text)
{
	Console.Write(text);
	int number;

	while (!int.TryParse(Console.ReadLine(), out number))
	{
		Console.WriteLine("Error! Try again.");
	}

	return number;
}

int SumDigits(int number)
{
	int sum = 0;
	while (number > 0)
	{
		sum = sum + (number % 10);
		number = number / 10;
	} 
	return sum;
}

int number = ReadInt("Input number: ");
Console.WriteLine($"the sum of all the digits in the number {number} = {SumDigits(number)}");