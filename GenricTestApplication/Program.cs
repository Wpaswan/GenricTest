using GenricTestApplication;
Console.WriteLine("Enter three numbers:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = ComparisonOf3Numbers.FindMaxIntNumber(a, b, c);
if (max==0)
{
    Console.WriteLine("All three numbers are equal!!!");
}
else
{
    Console.WriteLine("Maximum among three:"+max);
}
