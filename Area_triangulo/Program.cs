double b, h, area;

Console.WriteLine("Enter the base of your triangle in cm:");
b=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the height of your triangle in cm:");
h = Convert.ToDouble(Console.ReadLine());

area = (b * h)/2;

Console.WriteLine("The area of your triangle is: " + area+ "cm²");
Console.ReadKey();