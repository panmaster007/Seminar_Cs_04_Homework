int[] CreateRandomArray(int lenght, int min, int max)
{
	int[] array = new int[lenght];
	Random random = new Random();
	for (int i = 0; i < lenght; i++)
	{
		array[i] = random.Next(min, max +1);
	}
	return array;
}

void OutputArray(int[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write(array[i]);
		if (i < array.Length - 1)
		Console.Write(", ");
	}
	Console.WriteLine("]");
}

int[] array = CreateRandomArray(8, 0, 100);
OutputArray(array);