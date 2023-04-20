Console.WriteLine("Hola, el siguiente programa le pedirá dos números para sumarlos, restarlos, multiplicarlos y dividirlos");
Console.WriteLine("Introduzca el primer número");
var primerNumero = Console.ReadLine();
int numero1 = int.Parse(primerNumero);
Console.WriteLine("Introduzca el segudno número");
var segundoNumero = Console.ReadLine();
int numero2 = int.Parse(segundoNumero);
Suma(numero1,numero2);
static int Suma(int sumando1, int sumando2)
{
    int resultado = sumando1 + sumando2;
    Console.WriteLine("El resultado de sumar los números " + sumando1 + " y " + sumando2 + " es: " + resultado);
    return resultado;
}
Resta(numero1,numero2);
static int Resta(int minuendo, int substraendo)
{
    int resultado = minuendo - substraendo;
    Console.WriteLine("El resultado de restar los números " + minuendo + " y " + substraendo + " es: " + resultado);
    return resultado;
}
Producto(numero1,numero2);
static int Producto(int factor1, int factor2)
{
    int resultado = factor1 * factor2;
    Console.WriteLine("El resultado de multiplicar los números " + factor1 + " y " + factor2 + " es: " + resultado);
    return resultado;
}
Division(numero1,numero2);
static int Division(int dividendo, int divisor)
{
    int resultado = dividendo / divisor;
    Console.WriteLine("El resultado de dividir los números " + dividendo + " y " + divisor + " es: " + resultado);
    return resultado;
}