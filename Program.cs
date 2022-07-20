// Task 19 
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Enter the number: ");
string numberN = Console.ReadLine();

void CheckingNumber(string numberN)
{
 if (numberN[0]==numberN[4] && numberN[1]==numberN[3]){
 Console.WriteLine($"Your number: {numberN} - palindrome");
  }
 else Console.WriteLine($"Your number: {numberN} - is are not a palindrome");
}
if (numberN.Length == 5)
{
 CheckingNumber(numberN);
}
else Console.WriteLine($"Enter the correct number");

// Task 21
// Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

Console.WriteLine("Enter the coordinates by X of the first point");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinates by Y of the first point");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinates by Z of the first point");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the coordinates by X of the second point");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinates by Y of the second point");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the coordinates by Z of the second point");
double z2 = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine(result);

// Task 23
// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.

Console.WriteLine("Enter the number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Table of cubes: ");
for (int i = 0; i < numberN; i++)
{
    Console.WriteLine($"{Math.Pow(i+1, 3)} ");
}

