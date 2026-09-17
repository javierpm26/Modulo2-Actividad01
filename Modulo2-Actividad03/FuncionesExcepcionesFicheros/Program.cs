// BLOQUE 1 - FUNCIONES

// Ejercicio 1 - Primera función
/*static void MostrarMensaje()
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


// Ejercicio 4 - Varios parámetros y retorno
static double CalcularMedia(double num1, double num2, double num3)
{
    return (num1 + num2 + num3) / 3;
}
Console.WriteLine($"La media es {CalcularMedia(5.0, 2.5, 3.75)}");
Console.WriteLine($"La media es {CalcularMedia(3.0, 2.5, 10)}");


// Ejercicio 5 - Variables locales y ámbito
static void MostrarAmbito()
{
    int numeroLocal = 20;

    Console.WriteLine($"El número dentro de la función es {numeroLocal}");
}

MostrarAmbito();

//Esto daría error:
//Console.WriteLine(numeroLocal);



// BLOQUE 2 - PASO DE PARÁMETROS Y RECURSIVIDAD 

// Ejercicio 6 - Paso por valor
int numero1 = 10; //Esta es la variable número original

static void Cambiar(int numero1)
{
    numero1 = 26; // Esta variable numero es una copia que usa la función
    Console.WriteLine($"Aquí numero tiene un valor de {numero1}"); // Muestra lo que vale la copia dentro de la función

}
Cambiar(numero1); // Llamar a la función hace una copia de la variable numero al que machaca su valor que es 10 a 26
Console.WriteLine($"Numero aquí vale {numero1}");


// Ejercicio 7 - ref
int numero2 = 10;

static void Cambiar2(ref int numero2)
{
    numero2 = 100;
    Console.WriteLine($"Aquí numero tiene un valor de {numero2}");

}
Cambiar2(ref numero2);
Console.WriteLine($"Numero aquí vale {numero2}");


// Ejercicio 8 - out

int numero3 = 5;

static void Cambiar3(int numero3, out int nDoble, out int nTriple)
{
    nDoble = numero3 * 2;
    nTriple = numero3 * 3;

    Console.WriteLine($"El doble de {numero3} es {nDoble}");
    Console.WriteLine($"El triple de {numero3} es {nTriple}");

}
Cambiar3(numero3, out int nDoble, out int nTriple);
Console.WriteLine(numero3);


// Ejercicio 9 - Recursividad
static void cuentaAtras(int numero)
{
    if (numero <= 0)
    {
        return;
    }
    Console.WriteLine(numero);
    cuentaAtras(numero -1);
}

cuentaAtras(20);*/



// BLOQUE 3 - EXCEPCIONES Y VALIDACION

// Ejercicio 10 - Detectar una excepción
string letras = "abc";

try
{
    int numConvertido = int.Parse(letras);
}
catch
{
    Console.WriteLine("No se puede convertir un tipo string a int.");
}
