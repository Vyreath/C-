using System;

int Numero = 0;
do
{
   
    Console.WriteLine("Escribe un numero positivo:");
    Numero = Convert.ToInt32(Console.ReadLine());
    
    if (Numero <= 0)
    {
        Console.WriteLine("Error, debes escribir un numero postivo");
        Console.WriteLine("---------------------------------------");
    }
    
   

}
while (Numero <= 0);


Console.WriteLine($"El numero ingresado es {Numero} w");
Console.WriteLine("----------------------------------");
