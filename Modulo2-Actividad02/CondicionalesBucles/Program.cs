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


// Ejercicio 4 - Temperatura
Console.WriteLine("Dime una temperatura: ");
decimal temperatura = decimal.Parse(Console.ReadLine() ?? "");

if (temperatura > 30)
{
    Console.WriteLine($"Hay {temperatura} grados, hace mucho calor");
}
else
{
    Console.WriteLine($"Hay {temperatura} grados, hace fresquito");
}



// NIVEL 2 - IF + ELSE

// Ejercicio 5 - Par o impar
Console.WriteLine("Introduce un número entero: ");
int numero2 = int.Parse(Console.ReadLine() ?? "");

if (numero2%2 == 0)
{
    Console.WriteLine("El número es par.");
}
else
{
    Console.WriteLine("El número es impar.");
}


// Ejercicio 6 - Positivo, negativo o cero
Console.WriteLine("Introduce un número entero:");
int numero3 = int.Parse(Console.ReadLine() ?? "");

if (numero3 > 0)
{
    Console.WriteLine($"{numero3} es un número positivo");
}
else if (numero3 == 0)
{
    Console.WriteLine($"{numero3} es cero (0)");
}
else
{
    Console.WriteLine($"{numero3} es un número negativo");
}


// Ejercicio 7 - Contraseña
string contrasenaCorrecta = "1234";

Console.WriteLine("Introduce la contraseña: ");
string contrasena = Console.ReadLine() ?? "";

if (contrasena == contrasenaCorrecta)
{
    Console.WriteLine("Contraseña correcta");
}
else
{
    Console.WriteLine("Contraseña incorrecta");
}


// Ejercicio 8 - Calificación
Console.WriteLine("Dame una nota: ");
decimal nota2 = decimal.Parse(Console.ReadLine() ?? "");

if (nota2 < 5)
{
    Console.WriteLine("Suspenso");
}
else if (nota2 < 7)
{
    Console.WriteLine("Aprobado");
}
else if (nota2 < 9)
{
    Console.WriteLine("Notable");
}
else if (nota2 < 10 || nota2 == 10)
{
    Console.WriteLine("Sobresaliente");
}
else
{
    Console.WriteLine("Nota no válida");
}


// Ejercicio 9 - Edad
Console.WriteLine("Introduce tu edad: ");
int edad2 = int.Parse(Console.ReadLine() ?? "");

if (edad2 < 13)
{
    Console.WriteLine("Eres un niño");
}
else if (edad2 <= 17)
{
    Console.WriteLine("Eres un adolescente");
} 
else if (edad2 <= 64)
{
    Console.WriteLine("Eres un adulto");
}
else if (edad2 <= 100)
{
    Console.WriteLine("Eres una persona mayor");
}
else
{
    Console.WriteLine("Edad inválida");
}