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


