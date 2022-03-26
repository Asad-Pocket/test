int[][,] a = new int[][,]
{
		new int[, ] {{1, 3}, {5, 7}},
		new int[, ] {{0, 2}, {4, 6}, {8, 10}},
		new int[, ] {{11, 22}, {99, 88}, {0, 9}}
};
for (int i = 0; i < a.Length; i++)
{
	int index = 0;
	for (int j = 0; j < a[i].GetLength(index); j++)
	{
		for (int k = 0; k < a[j].Rank; k++)
			Console.Write("Array[" + i + "," + j + "," + k + "] = "
										+ a[i][j, k] + "   ");
		Console.WriteLine();
	}
	Console.WriteLine();
	index++;
	Console.WriteLine();
}