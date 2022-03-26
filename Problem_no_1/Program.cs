Console.WriteLine("Enter The value : ");
int value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Enter The value : ");
int n = Convert.ToInt32(Console.ReadLine());
String str = Convert.ToString(value, 2);
Console.Write("Binary representation : " + str);
Console.WriteLine();
int a = Convert.ToInt32(str);
Console.Write("Int representation : " + a);
int Length = str.Length;
int[] arr = new int[Length + 100];
for (int i = 0; a != 0; i++)
{
    int temp = a % 10;
    arr[i] = temp;
    a = a / 10;
}
Console.WriteLine();
Console.Write("Array :");
for (int i = 0; i < Length; i++)
    Console.Write(arr[i] + " ");
Console.WriteLine();
int[] arr1 = new int[Length + 100];
Console.WriteLine();
for (int i = 1; i <= n; i++)
{
    Console.Write("Binary representaion rotates " + i + " times : ");
    int temp = arr[0];
    for (int j = 0; j < Length - 1; j++)
    {
        arr1[j] = arr[j + 1];
        Console.Write(arr1[j] + " ");
    }
    arr1[Length - 1] = temp;
    Console.Write(arr1[Length - 1]);
    for (int k = 0; k < Length; k++)
        arr[k] = arr1[k];
    Console.WriteLine();
    Console.WriteLine();
}
Console.ReadKey();

