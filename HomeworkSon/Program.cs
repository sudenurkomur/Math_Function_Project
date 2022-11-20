int x;
int y;
int math;
Console.Write("Please enter a number between 2 and 50: ");
x = Convert.ToInt32(Console.ReadLine());
if (x >= 51 || x < 2)
{
    Console.WriteLine("You wrote a wrong number.");
    return;
}
Console.Write("Please enter a number between 25 and 30: ");
y = Convert.ToInt32(Console.ReadLine());
if (y > 30 || y < 25)
{
    Console.WriteLine("You wrote a wrong number.");
    return;
}
Console.Write("Please enter 0 for * or 1 for +: ");
math = Convert.ToInt32(Console.ReadLine());
if (math != 1 && math != 0)
{
    Console.WriteLine("You wrote a wrong operator.");
    return;
}
int a = 2;
int b = 5;
double shortest = 8.3209871e+81;     // I equated the first fraction to result 1. In the first fraction, 2x delta is 5x the min value. so the shortest value is 31! I did. (ilk sonuç y! her türlü küçük olacaktır. Bu yüzden shortest 'ı 31! eşitledim.)
double result1 = 0;
double result2 = 1;
double result3 = 0;
double son_result = 0, faktoriyel = 0;
if (math == 0)
{
    if ((a * x) * (b * x) < shortest) //2x delta 5x < y! part 
    {
        shortest = (a * x) * (b * x);
    }

    result1 = result1 + shortest / (1 + 3);
    a += 3;
    b += 3;
    result3 = result3 + result1;

    for (int i = 1; i < 25; i++)
    {
        result2 = (a * x) * (b * x);

        faktoriyel = 1;                  // Calculate the factorial of y, one less at each step (her adımda bir eksiği alınan y nin faktöriyeli hesaplandı)
        for (int k = 1; k <= y; k++)
        {
            faktoriyel = faktoriyel * k;
        }
        double pay;
        if (faktoriyel < result2)
        {
            pay = faktoriyel;
        }
        else
        {
            pay = result2;
        }
        double payda = 0;

        for (int m = 2 * i + 1; m <= (3 + (4 * i)); m += 2)  // The equation of the denominator starts on this line 
        {
            double upper = 1;                     //the exponent of the denominator is taken here
            for (int n = 1; n <= (i + 1); n++)
            {
                upper = upper * m;
            }
            payda = payda + upper;
        }
        a = a + 3;
        b = b + 3;
        y = y - 1;

        son_result = pay / payda;

        if (i % 2 == 0)
        {
            result3 = result3 - son_result;
        }
        else
        {
            result3 = result3 + son_result;
        }
    }
    Console.WriteLine(result3);
}

if (math == 1)
{
    if ((a * x) + (b * x) < shortest) //2x delta 5x < y! result1 part 
    {
        shortest = (a * x) + (b * x);
    }

    result1 = result1 + shortest / (1 + 3);
    a += 3;
    b += 3;
    result3 = result3 + result1;

    for (int i = 1; i < 25; i++)
    {
        result2 = (a * x) + (b * x);
        faktoriyel = 1;                  // Calculate the factorial of y, one less at each step (her adımda bir eksiği alınan y nin faktöriyeli hesaplandı)
        for (int k = 1; k <= y; k++)
        {
            faktoriyel = faktoriyel * k;
        }
        double pay;
        if (faktoriyel < result2)
        {
            pay = faktoriyel;
        }
        else
        {
            pay = result2;
        }
        double payda = 0;
        for (int m = 2 * i + 1; m <= (3 + (4 * i)); m += 2)  // The equation of the denominator starts on this line 
        {
            double upper = 1;
            for (int n = 1; n <= (i + 1); n++)     //the exponent of the denominator is taken here
            {
                upper = upper * m;
            }
            payda = payda + upper;
        }
        a = a + 3;
        b = b + 3;
        y = y - 1;
        son_result = pay / payda;
        if (i % 2 == 0)
        {
            result3 = result3 - son_result;
        }
        else
        {
            result3 = result3 + son_result;
        }
    }
    Console.WriteLine(result3);
}
