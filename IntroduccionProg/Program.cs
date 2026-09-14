//NIVEL 1 - MOSTRAR INFORMACIÓN

//Ejercicio 1 - Presentación


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