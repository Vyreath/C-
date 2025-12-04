
Console.WriteLine("INTENTA ADIVINAR EL NUMERO EN EL QUE ESTOY PENSANDO");
Random NumeroRandom = new Random();
int NumeroAAdivinar = NumeroRandom.Next(1, 101);
int Num = Convert.ToInt32(Console.ReadLine()); ;
int Intentos = 0;

while (Num != NumeroAAdivinar)
{
    Intentos++;
    if (Num > NumeroAAdivinar)
    {
        Console.WriteLine("Te pasaste bb");
        Num = Convert.ToInt32(Console.ReadLine());
    }
    else if (Num < NumeroAAdivinar)
    {
        Console.WriteLine("Te falta bb");
        Num = Convert.ToInt32(Console.ReadLine());
    }


}

Console.WriteLine($"Estas correcto bb, el numero de intentos fue {Intentos}");
