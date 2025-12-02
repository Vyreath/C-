
void suma ()
{
    int a = 8 + 9;
    Console.WriteLine(a);
}

int ReturnSuma()
{
    int a = 8 + 9;
    return a;
}

Console.WriteLine("Escribe el radio del circulo");
double radio = Convert.ToDouble(Console.ReadLine());


double area (double pRadio, double pi = 3.1416  )
{

    double area = pi * (pRadio*pRadio);
    
    return area;
}

double a  = area(radio);

Console.WriteLine(a);

double circunferencia(double pRadio, double pi = 3.1416)
{

    double circunferencia = 2 * pRadio * pi;

    return circunferencia;
}

double b = circunferencia(radio);
Console.WriteLine(b);
