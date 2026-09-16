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


// Ejercicio 10 - Precio con descuento
decimal precioSinDescuento = 0m;
decimal descuento = 0m;
decimal precioFinal = 0m;

Console.WriteLine("Precio del producto");
precioSinDescuento = decimal.Parse(Console.ReadLine() ?? "");

if (precioSinDescuento < 50)
{
    Console.WriteLine("El precio es menor que 50€: Sin descuento");
}
else if (precioSinDescuento < 100)
{
    descuento = (precioSinDescuento * 5.00m ) / 100;
    precioFinal = precioSinDescuento - descuento;
    Console.WriteLine($"El precio es {precioSinDescuento} se le aplica un 5% y se queda en {precioFinal}");
}
else
{
    descuento = (precioSinDescuento * 10.00m) / 100;
    precioFinal = precioSinDescuento - descuento;
    Console.WriteLine($"El precio es {precioSinDescuento} se le aplica UN 10% y se queda en {precioFinal}.");
}



//  NIVEL 4 - SWITCH

// Ejercicio 11 - Día de la semana
Console.WriteLine("Introduce un número del 1 al 7: ");
int numDia = int.Parse(Console.ReadLine() ?? "");

switch (numDia)
{
    case 1:
        Console.WriteLine("El día 1 de la semana es Lunes");
        break;
    case 2:
        Console.WriteLine("El día 2 de la semana es Martes");
        break;
    case 3:
        Console.WriteLine("El día 3 de la semana es Miércoles");
        break;
    case 4:
        Console.WriteLine("El día 4 de la semana es Jueves");
        break;
    case 5:
        Console.WriteLine("El día 5 de la semana es Viernes");
        break;
    case 6:
        Console.WriteLine("El día 6 de la semana es Sábado");
        break;
    case 7:
        Console.WriteLine("El día 7 de la semana es Domingo");
        break;
    default:
        Console.WriteLine("Día no válido");
        break;
}*/


// Ejercicio 12 - Menú

int opcionUsuario = 0;

Console.WriteLine("1. Crear\n2. Consultar\n3. Modificar\n4. Eliminar");

Console.Write("Escribe una opción:");
opcionUsuario = int.Parse(Console.ReadLine() ?? "");


switch (opcionUsuario)
{
    case 1:
        Console.WriteLine("Has elegido CREAR");
        break;
    case 2:
        Console.WriteLine("Has elegido CONSULTAR");
        break;
    case 3:
        Console.WriteLine("Has elegido MODIFICAR");
        break;
    case 4:
        Console.WriteLine("Has elegido ELIMINAR");
        break;
    default:
        Console.WriteLine("¡OPCIÓN NO VÁLIDA!");
        break;
}

