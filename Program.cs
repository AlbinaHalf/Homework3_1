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


