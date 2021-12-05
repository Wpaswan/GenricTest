using GenricTestApplication;
Console.WriteLine("-----------------------please select any            ----------------------------");
Console.WriteLine("-----------------------1.Maximum between three integer----------------------------");
Console.WriteLine("-----------------------2.Maximum between three float__----------------------------");
Console.WriteLine("-----------------------3.Maximum between three String__----------------------------");
int choice=Convert.ToInt32(Console.ReadLine());
switch (choice) {
    case 1:
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
        break;
    case 2:
Console.WriteLine("Enter three float numbers:");
float firstfloat=Convert.ToSingle(Console.ReadLine());

float secondfloat = Convert.ToSingle(Console.ReadLine());
float thirdfloat = Convert.ToSingle(Console.ReadLine());
float maxfloat=ComparisonOf3Numbers.FindMaxFloatNumber(firstfloat, secondfloat, thirdfloat);
if (maxfloat==0)
{
    Console.WriteLine("All three numbers are equal!!!");
}
else
{
    Console.WriteLine("Maximum among three:"+maxfloat);
}
        break;
    case 3:
        Console.WriteLine("Enter three words:");
        string word1=Console.ReadLine();
        string word2 = Console.ReadLine();
        string word3 = Console.ReadLine();

        
        string maxString = ComparisonOf3Numbers.FindMaxFloatNumber(word1, word2, word3);

        if (maxString==null)
        {
            Console.WriteLine("All three numbers are equal!!!");
        }
        else
        {
            Console.WriteLine("Maximum among three:"+maxString);
        }
        break;
    default:
        Console.WriteLine("Please select a valid one!!");
        break;
}
