// See https://aka.ms/new-console-template for more information
Console.Write("Enter number : ");
double number = int.Parse(Console.ReadLine());

for (int i = 1; i > 0; i++)
{
    int x = (int)Math.Pow(10, i);
    double y = (number / x);
    if (y >= 1 && y < 10)
    {
        Console.WriteLine($"{y} x 10 ^ {i}");
        break;
    }
    if(i > number + 2)
    {
        break;
    }
}
