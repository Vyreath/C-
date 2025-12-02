string[,] notas =
{
    {"Pablo","10", "8", "1"},
    {"Ezequiel","2", "8", "1" },
    {"Alfredo Adame","1", "9", "4"},
    {"Fer","10", "9", "9" },
    {"Pedro","9", "8", "8"}
};

double promedio = 0;
double notaNum = 0;
double Resultado = 0;
String nombre = " ";


for (int i = 0;i < notas.GetLength(0);i++)
{
    for (int j = 1;j < notas.GetLength(1);j++)
    {

        notaNum = Convert.ToDouble(notas[i, j]);
        promedio += notaNum;
        Resultado = promedio/(notas.GetLength(1)-1);

        

        
    }
    for (int j = 0; j < notas.GetLength(1); j++)
    {
       nombre += notas [i, j];
        nombre += "   ";
    }

    Console.WriteLine($" {nombre} {Resultado:0.##}");
    nombre = " ";
    promedio = 0;
}
