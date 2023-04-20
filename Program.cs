Console.WriteLine("Hola, el siguiente programa le pedirá dos números para sumarlos, restarlos, multiplicarlos y dividirlos");
Console.WriteLine("Introduzca el primer número");
var primerNumero = Console.ReadLine();
int numero1 = int.Parse(primerNumero);
Console.WriteLine("Introduzca el segudno número");
var segundoNumero = Console.ReadLine();
int numero2 = int.Parse(segundoNumero);
Suma(numero1,numero2);
static int Suma(int numero1, int numero2)
{
    int resultado = numero1 + numero2;
    Console.WriteLine("El resultado de sumar los números " + numero1 + " y " + numero2 + " es: " + resultado);
    return resultado;
}
Resta(numero1,numero2);
static int Resta(int numero1, int numero2)
{
    int resultado = numero1 - numero2;
    Console.WriteLine("El resultado de restar los números " + numero1 + " y " + numero2 + " es: " + resultado);
    return resultado;
}
Producto(numero1,numero2);
static int Producto(int numero1, int numero2)
{
    int resultado = numero1 * numero2;
    Console.WriteLine("El resultado de multiplicar los números " + numero1 + " y " + numero2 + " es: " + resultado);
    return resultado;
}
Division(numero1,numero2);
static int Division(int numero1, int numero2)
{
    int resultado = numero1 / numero2;
    Console.WriteLine("El resultado de dividir los números " + numero1 + " y " + numero2 + " es: " + resultado);
    return resultado;
}