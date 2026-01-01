
namespace PILA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> strings = new Stack<string>();

            strings.Push("Hola");
            strings.Push("pablo");
            strings.Push("pedro");

            Console.WriteLine($"Tamanho de la fila {strings.Count()}");

            for (int i = 0; i <= strings.Count()+1; i++)
            {
                Console.WriteLine(strings.Pop());

            }

        }
    }
}
