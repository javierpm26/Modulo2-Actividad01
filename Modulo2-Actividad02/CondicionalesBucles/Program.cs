// NIVEL 1 - IF

// Ejercicio 1 - Mayor de edad
Console.WriteLine("Introduce tu edad: ");
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
