//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.WriteLine ("Введите пятизначное число:");
int a = int.Parse(Console.ReadLine());
if (a>=100000) 
{
Console.WriteLine("Число не является пятизначным");
}
else if (a<10000) 
{
Console.WriteLine("Число не является пятизначным");
}
else 
{
int x1 = a/10000;
int y1 = a%10;
int x2 = (a/1000)%10;
int y2 = (a%100)/10;
if (x1 == y1) { if (x2 == y2) {Console.WriteLine("Число является палиндромом");}
else {Console.WriteLine("Число не является палиндромом");}}
else {Console.WriteLine("Число не является палиндромом");}
}