
Console.WriteLine("Escribe un texto: ");
string texto = Console.ReadLine();

int ContarCaracteres(string pTexto)
{
    return pTexto.Length;
}

int ContarPalabras (string pTexto)
{
    string[] palabras = pTexto.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    foreach (string p in palabras)
    {
        Console.WriteLine(p);
    }
    return palabras.Length;
}

int caracteres = ContarCaracteres(texto);
Console.WriteLine($"Total del caracteres: {caracteres}");

int palabras = ContarPalabras(texto);
Console.WriteLine($"Total del palabras: {palabras}");

