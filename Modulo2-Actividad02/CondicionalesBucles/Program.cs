// NIVEL 1 - IF

// Ejercicio 1 - Mayor de edad
/*Console.WriteLine("Introduce tu edad: ");
int edad = int.Parse(Console.ReadLine() ?? "");

if (edad >= 18)
{
    Console.WriteLine("Es mayor de edad");
}
else
{
    Console.WriteLine("Es menor de edad");
}


// Ejercicio 2 - Número positivo
Console.WriteLine("Introduce un número entero: ");
int numero = int.Parse(Console.ReadLine() ?? "");

if (numero > 0)
{
    Console.WriteLine($"El número {numero} es mayor que 0");
}
else if (numero == 0)
{
    Console.WriteLine("El número es 0");
}
else
{
    Console.WriteLine($"El número es negativo");
}
*/

// Ejercicio 3 - Nota aprobada
Console.WriteLine("Introduce tu nota: ");
int nota = int.Parse(Console.ReadLine() ?? "");

if (nota > 10 || nota < 0)
{
    Console.WriteLine("Nota no válida");
}
else if (nota >= 5)
{
    Console.WriteLine("Estás aprobado");
}
else
{
    Console.WriteLine("Estás suspenso");
}