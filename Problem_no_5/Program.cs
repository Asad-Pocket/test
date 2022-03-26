int[,] arr = new int[50, 50];

int row = Convert.ToInt32(Console.ReadLine());
int col = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        arr[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
int sum = 0, sum1 = 0;
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        if (i == j)
            sum += arr[i, j];
    }
}
for (int i = 0; i < row; i++)
{
    for (int j = col - 1; j >= 0;)
    {
        sum1 += arr[i, j];
        break;
    }
}
Console.WriteLine("First Diagonal Element Sum : " + sum);
Console.WriteLine("Second Diagonal Elements Sum : " + sum1);
int sum2 = sum + sum1;
Console.WriteLine("Summation Of Two Diagonal Elements Are : " + sum2);
