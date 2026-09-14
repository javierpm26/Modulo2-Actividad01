//NIVEL 1 - MOSTRAR INFORMACIÓN

//Ejercicio 1 - Presentación
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

string nombre = "Beatriz";
const string CIUDAD = "Socuéllamos";
int edad = 27;
string comidaFavorita = "macarrones";

Console.WriteLine($"Hola, me llamo {nombre}, y vivo en {CIUDAD}. \nTengo {edad} años, y mi comida favorita es un plato de {comidaFavorita}. ");


//Ejercicio 2 - Datos básicos
string nombre2 = "Javier";
int edad2 = 25;
double altura = 1.72;
bool estudiante = true;

Console.WriteLine($"Hola me llamo {nombre2}, y tengo {edad2} años. Mido {altura} metros");

Console.WriteLine($"¿Soy estudiante?{estudiante}");

//NIVEL 2 - PEDIR DATOS

//Ejercicio 3 - Saludo
string nombre3 = "";
string ciudad2 = "";

Console.WriteLine("Introduce tu nombre:");
nombre3 = Console.ReadLine() ?? "";

Console.WriteLine("Introduce tu ciudad:");
ciudad2 = Console.ReadLine() ?? "";

Console.WriteLine($"Hola, {nombre3}. Tu ciudad, {ciudad2}, es muy bonita.");


//Ejercicio 4 - Edad
int edad3 = 0;
Console.WriteLine("Dime tu edad");
edad3 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"Ok, tu edad es {edad3}");

//Ejercicio 5 - Producto
string nombreProd = "";
double precioProd = 0.0;

Console.WriteLine("Introduce el nombre del producto: ");
nombreProd = Console.ReadLine() ?? "";
Console.WriteLine("Introduce el precio del producto: ");
precioProd = double.Parse(Console.ReadLine() ?? "");
//Hay que meter siempre el número en consola cuando lo pida o dará error al quedar como null e intentar convertir el string a double
//Para introducir decimales por consola, utilizar ,

Console.WriteLine($"El producto introducido es {nombreProd} con un valor de {precioProd} euros.");


// NIVEL 3 - OPERACIONES SENCILLAS

// Ejercicio 6 - Suma de dos números
int numA =  0;
int numB = 0;

Console.WriteLine("Numero entero A: ");
numA = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Numero entero B: ");
numB = int.Parse(Console.ReadLine() ?? "");

// Sumar
int suma = numA + numB;
Console.WriteLine($"El resultado de la suma es: {suma}.");

// Resta
int resta = numA - numB;
Console.WriteLine($"El resultado de la resta es: {resta}");

// Multiplicación
int multiplicacion = numA * numB;
Console.WriteLine($"El resultado de la multiplicación es {multiplicacion}");

//Ejercicio 7 - División y resto

//División
Console.WriteLine("Introduce un número: ");
int numC = int.Parse(Console.ReadLine() ?? "");

//Resto
Console.WriteLine("Introduce otro número: ");
int numD = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"El resultado de la división entre {numC} y {numD} es {numC / numD}.");
Console.WriteLine($"El resto de la división entre {numC} y {numD} es {numC % numD}.");


// Ejercicio 8 - Conversión de minutos

int minutos = 0;

Console.WriteLine("Minutos a convertir a horas");
minutos = int.Parse(Console.ReadLine() ?? "");

int horas = minutos / 60;
Console.WriteLine($"{minutos} minutos son {horas} horas");

int minRestantes = minutos % 60;
Console.WriteLine($"Minutos restantes {minRestantes}");

//NIVEL 4 - OPERACIONES CON DECIMALES

// Ejercicio 9 - Área de un rectángulo
double baseR = 0.0;
double alturaR = 0.0;

Console.WriteLine("Introduce la base de tu rectángulo: ");
baseR = double.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Introduce la altura de tu rectángulo: ");
alturaR = double.Parse(Console.ReadLine() ?? "");

//área = base * altura
Console.WriteLine($"El área de tu rectángulo es {baseR * alturaR}.");



// Ejercicio 10 - Precio Final

decimal productA = 0;
decimal productB = 0;

Console.WriteLine("Producto A: ");
productA = decimal.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Producto B: ");
productB = decimal.Parse(Console.ReadLine() ?? "");

 decimal precioTotal = productA + productB;
Console.WriteLine($"El precio total de los productos {productA} y {productB} es {precioTotal}");

decimal precioMedio = precioTotal / 2;
Console.WriteLine($"El precio medio de {productA} y {productB} es {precioMedio}");




