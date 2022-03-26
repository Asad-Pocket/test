
String str1, str2;
Console.Write("Input the Number : ");
str1 = Console.ReadLine();
Console.Write("Input the Number : ");
str2 = Console.ReadLine();
String res = "";
if (str1.Length < str2.Length)
    str1 = "0" + str1;
if (str2.Length < str1.Length)
    str2 = "0" + str2;
int carry = 0;
for (int i = str1.Length - 1; i >= 0; i--)
{
    int tmp = str1[i] - 48 + str2[i] - 48 + carry;
    carry = tmp / 10;
    tmp = tmp % 10;
    res = (char)(tmp + 48) + res;
}
if (carry > 0) 
     res = "1" + res;
Console.WriteLine("The Sum Of Two Large Numbers : " + res);