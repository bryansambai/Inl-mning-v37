// Split the nota
Console.WriteLine("Ange notans totala belopp");
int summa = int.Parse(Console.ReadLine());
Console.WriteLine("Hur många vänner är ni?");
int antalVänner = int.Parse(Console.ReadLine());
Console.WriteLine("Ange dricksen i decimalform");
double dricks = double.Parse(Console.ReadLine());
double total = summa + (summa * dricks);
double perPerson = total / antalVänner;
Console.WriteLine("Varje person ska betala: " + perPerson + "kr");

