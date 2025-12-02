//Ejercicio 1

using System.Runtime.Serialization.Formatters;

Random random = new Random();

int[] numeros = new int[10];

int resultado = 0;
int sumaPar = 0;
int sumaImpar = 0;
for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = random.Next(-50,50);
    if (numeros[i] % 2 == 0)
    {
        resultado += numeros[i];
        Console.WriteLine("Este es par:" + numeros[i]);
        sumaPar += numeros[i];
    }
    else
    {
        Console.WriteLine($"Este es impar {numeros[i]}");
        resultado -= numeros[i];
        sumaImpar -= numeros[i];
    }

}

Console.WriteLine($"Este es la suma par: {sumaPar}");
Console.WriteLine($"Este es la suma impar: {sumaImpar}");
Console.WriteLine($"Este es el resultado: {resultado}");


//ejercicio 2 

int [] calificaciones = new int[30];
int deficientes = 0;
int irregulares = 0;
int regulares = 0;
int buenos = 0;
int excelentes = 0;

for (int i = 0;i < calificaciones.Length;i++)
{
    calificaciones[i] = random.Next(0,11);
    if (calificaciones[i] <= 2)
    {
        deficientes++;

    }


    else if (calificaciones[i] <= 6 && calificaciones[i] > 2)
    {
        irregulares++;

    }

    else if (calificaciones[i] <= 8 && calificaciones[i] > 6)
    {
        regulares++;
    }
    else if (calificaciones[i] == 9)
    {
        buenos++;
    }
    else 
    {
        excelentes++;
    }
 
}

Console.WriteLine($"Estudiantes deficientes {deficientes}");
Console.WriteLine($"Estudiantes irregulares {irregulares}");
Console.WriteLine($"Estudiantes regulares {regulares}");
Console.WriteLine($"Estudiantes buenos {buenos}");
Console.WriteLine($"Estudiantes excelentes {excelentes}");

//ejercicio 3

int[][] ventas = new int[7][];

ventas[0] = new int [] {12,42,42,431,113};
ventas[1] = new int []{124,42 };
ventas[2] = new int []{1224,11,2 };
ventas[3] = new int []{121,442,432,123 };
ventas[4] = new int []{ 124,124,11,32};
ventas[5] = new int []{12 };
ventas[6] = new int []{43,421 };


int totalDeVentasDia = 0;

for (int i = 0; i < ventas.Length; i++)
{
    for (int j = 0; j < ventas[i].Length ; j++)
    {
         totalDeVentasDia += ventas[i][j];
        
    }

    Console.WriteLine($"Total de ventas dia: {totalDeVentasDia}");
    totalDeVentasDia = 0;
}


//Ejercicio 4


int[,] matriz = new int[3, 3];

for (int i = 0; i < matriz.GetLength(0); i ++)
{
    for (int j = 0;j < matriz.GetLength(1); j ++)
    {
        if (i == j)
        {
            matriz[i, j] = 1;
        }
        else
        {
            matriz [i, j] = 0;
        }
        Console.Write(matriz[i, j]);
        
    }
    Console.WriteLine();
}
