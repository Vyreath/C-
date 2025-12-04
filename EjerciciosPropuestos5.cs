//Ejercicio 1


Console.WriteLine("Dame la base");
double bases = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Dame la altura: ");
double altura = Convert.ToDouble(Console.ReadLine());



double area (double pBase, double pAltura)
{
    return pBase * pAltura;
}

double respuestaArea = area(bases,altura);

Console.WriteLine($"Esta es la respuesta {respuestaArea}");

//Ejercicio 2

Console.WriteLine("Escribe tu salario anual: ");
double salarioAnual = Convert.ToDouble(Console.ReadLine());

double salarioAnualMetodo(double pSalarioAnual)
{
    if (pSalarioAnual <= 50000)
    {
        return pSalarioAnual - (pSalarioAnual * 0.1);
    }
    else if (pSalarioAnual > 50000 && pSalarioAnual <= 100000)
    {
        return pSalarioAnual - (pSalarioAnual * 0.15);
    }
    else
    {
        return pSalarioAnual - (pSalarioAnual * 0.2);
    }
   
}

double resultadosalarioAnualMetodo = salarioAnualMetodo(salarioAnual);

Console.WriteLine($"El resultado es : {resultadosalarioAnualMetodo}");

//ejercicio 3

double dineroTotal = 100000;
Console.WriteLine($"Tu saldo actual es de {dineroTotal}");

int respuesta = 0;

double depositar (double pdineroTotal, double suma)
{
    return pdineroTotal + suma;
}


double retirar(double pdineroTotal, double resta)
{
    return pdineroTotal - resta;
}

double consultar(double pdineroTotal)
{
    return pdineroTotal;
}



do
{
    Console.WriteLine("1.Depositar \n2.Retirar \n3.Consultar \n4.Salir");
    respuesta = Convert.ToInt32(Console.ReadLine());

    if (respuesta == 1)
    {
        Console.WriteLine("Escribe la cantidad que quieras depositar");
        double deposito  = Convert.ToDouble(Console.ReadLine());
        double resultadoDeposito = depositar(dineroTotal,deposito);
        Console.WriteLine(resultadoDeposito);
    }
    else if (respuesta == 2)
    {
        Console.WriteLine("Escribe la cantidad que quieras retirar");
        double retiro = Convert.ToDouble(Console.ReadLine());
        double resultadoRetiro = retirar(dineroTotal, retiro);
        Console.WriteLine(resultadoRetiro);
    }
    else if (respuesta == 3)
    {
       
        double resultadoRetiro = consultar(dineroTotal);
        Console.WriteLine(resultadoRetiro);
    }


} while ( respuesta != 4 );
