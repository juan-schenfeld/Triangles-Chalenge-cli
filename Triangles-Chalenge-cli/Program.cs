//Variables
double[] a = new double[2];
double[] b = new double[2];
double[] c = new double[2];

double abLength;
double bcLength;
double acLength;
double perimeter;

string equilateralMessage = "Triangle IS NOT 'Equilateral'";
string isoscelesMessage = "Triangle IS NOT 'Isosceles'";
string rigthMessage = "Triangle IS NOT 'Rigth'";

//Inputs

//point A
Console.WriteLine("Enter coordinate x of dot A:");
a[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot A:");
a[1] = Convert.ToDouble(Console.ReadLine());

//point B
Console.WriteLine("Enter coordinate x of dot B:");
b[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot B:");
b[1] = Convert.ToDouble(Console.ReadLine());

//point C
Console.WriteLine("Enter coordinate x of dot C:");
c[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot C:");
c[1] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Environment.NewLine);

//process

//side length
abLength = Math.Round(Math.Sqrt(Math.Pow(b[0] - a[0], 2) + Math.Pow(b[1] - a[1], 2)), 6);
bcLength = Math.Round(Math.Sqrt(Math.Pow(c[0] - b[0], 2) + Math.Pow(c[1] - b[1], 2)), 6);
acLength = Math.Round(Math.Sqrt(Math.Pow(a[0] - c[0], 2) + Math.Pow(a[1] - c[1], 2)), 6);
perimeter = abLength + bcLength + acLength;


//triangle type
if (abLength == bcLength && bcLength == acLength)
{
    equilateralMessage = "Triangle IS 'Equilateral'";
}
else 
{
    if (abLength == bcLength || bcLength == acLength || acLength == abLength)
    {
        isoscelesMessage = "Triangle IS 'Isosceles'";
    }

    if (Math.Pow(bcLength, 2) - (Math.Pow(abLength, 2) + Math.Pow(acLength, 2)) <= 1 * Math.Pow(10, -6))
    {
        rigthMessage = "Triangle IS 'Rigth'";
    }
}

//outputs 
Console.WriteLine("Length of AB is: " + abLength);
Console.WriteLine("Length of BC is: " + bcLength);
Console.WriteLine("Length of AC is: " + acLength);
Console.WriteLine();


Console.WriteLine(equilateralMessage);
Console.WriteLine(isoscelesMessage);
Console.WriteLine(rigthMessage);
Console.WriteLine();


Console.WriteLine("perimeter: " + perimeter);
Console.WriteLine();


Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");

for (int i = 0; i < perimeter; i += 2)
{
    Console.WriteLine(i);
}
