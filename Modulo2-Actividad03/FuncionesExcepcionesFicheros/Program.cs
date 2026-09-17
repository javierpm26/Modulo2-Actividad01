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

