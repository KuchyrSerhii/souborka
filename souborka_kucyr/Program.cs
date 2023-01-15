// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vítam Vás v Tribonacciho posloupnosti");
Console.WriteLine("Jakou byste chtěli delku sekvence? (minimalně 8)");

string z_klavensice = Console.ReadLine();
int delka_sekvence = Convert.ToInt16(z_klavensice);

if (delka_sekvence >= 8)
{
    Console.WriteLine("Zadali jste číslo větši než 8. Můžeme pokračovat ");
    Console.WriteLine("Zadejte první číslo");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Zadejte druhé číslo");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Zadejte třetí číslo");
    double c = Convert.ToDouble(Console.ReadLine());
    double d = a + b + c;
    Console.WriteLine("Tribonacciho posloupnost je: ");
    Console.Write(a + "\t" + b + "\t" + c + "\t");

    for (int i = 0; i < delka_sekvence; i++)
    {
        Console.Write("\t" + d);
        a = b;
        b = c;
        c = d;
        d = a + b + c;
        

    }
    Console.ReadKey();
}

else
{
Console.WriteLine("Zadali jste číslo menší než 8. Zadejte prosím znovu");
}

string z_klavensice_2 = Console.ReadLine();
int delka_sekvence_2 = Convert.ToInt16(z_klavensice_2);

    if (delka_sekvence_2 >= 8)
{
    Console.WriteLine("Zadali jste číslo větši než 8. Můžeme pokračovat ");
    Console.WriteLine("Zadejte první číslo");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Zadejte druhé číslo");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Zadejte třetí číslo");
    double c = Convert.ToDouble(Console.ReadLine());
    double d = a + b + c;
    Console.WriteLine("Tribonacciho posloupnost je: ");
    Console.Write(a + "\t" + b + "\t" + c + "\t");


    for (int i = 0; i < delka_sekvence_2; i++)
    {
        Console.Write("\t" + d);
        a = b;
        b = c;
        c = d;
        d = a + b + c;
        
    }
    Console.ReadKey();
}
