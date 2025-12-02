Console.WriteLine("Escribe el precio del producto: ");
int precio  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escribe la cantidad de productos: ");
int cantidad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escribe el descuento: ");
double descuento  = Convert.ToInt32(Console.ReadLine());
double subTotal = 0.0;
void calcularSubTotal(int pPrecio,int pCantidad)
{
    subTotal = pCantidad * pPrecio;
    Console.WriteLine(subTotal);
}

void Total(double pSubTotal, double pDescuento = 0,  double impuesto = 0.17 )
{
    double Total = pSubTotal + (impuesto * pSubTotal) - pDescuento ;
    Console.WriteLine(Total);
}

calcularSubTotal(precio, cantidad);

Total(subTotal, descuento);
