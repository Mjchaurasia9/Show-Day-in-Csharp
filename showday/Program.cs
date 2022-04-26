// See https://aka.ms/new-console-template for more information
Console.Write("Enter a number to show day -----\t");
int num = int.Parse(Console.ReadLine());
switch(num)
{
case 0:
Console.WriteLine("Today is Sunday");
break;
case 1:
Console.WriteLine("Today is Monday");
break;
case 2:
Console.WriteLine("Today is Tuesday");
break;
case 3:
Console.WriteLine("Today is Wednessday");
break;
case 4:
Console.WriteLine("Today is Thursday");
break;
case 5:
Console.WriteLine("Today is Friday");
break;
case 6:
Console.WriteLine("Today is Saturday");
break;
default:
Console.WriteLine("Invalid Number");
break; 
}
