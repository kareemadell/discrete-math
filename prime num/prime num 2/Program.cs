// See https://aka.ms/new-console-template for more information

Console.WriteLine("enter small number");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("enter bid number");
double num2 = double.Parse(Console.ReadLine()); 

if (num1 < num2)
{
    while (num1 < num2)
    {
        if ( num1 == 3) Console.WriteLine("3");
        else if ( num1 == 5 ) Console.WriteLine("5");
        else if (num1 == 9) Console.WriteLine("9");
        if (num1 % 2 != 0 && num1 % 3 != 0 && num1 % 4 != 0 && num1 % 5 != 0 && num1 % 6 != 0
                  && num1 % 9 != 0 && num1 % 8 != 0 && num1 % 7 != 0)


        {
            Console.WriteLine(num1);
        }
        num1 += 1;

    }

}
else Console.WriteLine("you have error ");

