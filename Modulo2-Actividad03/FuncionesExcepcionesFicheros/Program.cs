// BLOQUE 1 - FUNCIONES

// Ejercicio 1 - Primera función
static void MostrarMensaje()
{
    Console.WriteLine("Bienvenido al programa");
}

MostrarMensaje();


// Ejercicio 2 - Parámetros
static void saludar(string nombre)
{
    Console.WriteLine($"Hola {nombre}");
}

saludar("Andrea");
saludar("Javier");

// Ejercicio 3 - Función con retorno
static int Sumar(int numA, int numB)
{
    return numA + numB;
}

Console.WriteLine($"El resultado de la suma es {Sumar(5,10)}");
