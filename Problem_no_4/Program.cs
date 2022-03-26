
int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
for (int i = 0; i < a.Length; i++)
	Console.Write(a[i] + " ");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("The Reversed Array :");
Array.Reverse(a);
for (int i = 0; i < a.Length; i++)
	Console.Write(a[i] + " ");
Array.Reverse(a);
int[] b = new int[5];
int[] c = new int[5];
for (int i = 0, j = 0, k = 0; i < a.Length; i++)
{
	if (a[i] % 2 == 0)
	{
		b[j] = a[i];
		j++;
	}
	else
	{
		c[k] = a[i];
		k++;
	}
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Even Elements Are :");
for (int i = 0; i < b.Length; i++)
	Console.Write(b[i] + " ");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Odd Elements Are :");
for (int i = 0; i < c.Length; i++)
	Console.Write(c[i] + " ");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Even Array Reverse version :");
Array.Reverse(b);
for (int i = 0; i < b.Length; i++)
	Console.Write(b[i] + " ");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Odd Array Reverse version :");
Array.Reverse(c);
for (int i = 0; i < c.Length; i++)
	Console.Write(c[i] + " ");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Printing All Elements Separately Using Comma:");
Console.WriteLine();

for (int i = 0; i < b.Length; i++)
	Console.Write(b[i] + ", ");
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < c.Length; i++)
	Console.Write(c[i] + ", ");
Console.WriteLine();
Console.WriteLine();