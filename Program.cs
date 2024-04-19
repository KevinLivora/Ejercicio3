//Implementar en C# un programa que maneje un array de clases para almacenar las fechas de cumpleaños de n cantidad de amigos. Los datos a almacenar sobre cada amigo son nombre, día, mes y año. El programa debe indicarnos cuántos de nuestros amigos cumplen años en un mes determinado introducidos por teclado.

Console.Write("Ingrese la cantidad de amigos: ");
int cantidadAmigos = Convert.ToInt32(Console.ReadLine());

Amigo[] amigos = new Amigo[cantidadAmigos];

for (int i = 0; i < cantidadAmigos; i++)
{
    Console.WriteLine($"\nIngrese los datos del amigo {i + 1}:");
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();

    Console.Write("Día de cumpleaños: ");
    int dia = Convert.ToInt32(Console.ReadLine());

    Console.Write("Mes de cumpleaños: ");
    int mes = Convert.ToInt32(Console.ReadLine());

    Console.Write("Año de cumpleaños: ");
    int anio = Convert.ToInt32(Console.ReadLine());

    amigos[i] = new Amigo
    {
        Nombre = nombre,
        Dia = dia,
        Mes = mes,
        Anio = anio
    };
}

Console.WriteLine("\nIngrese el número de mes para verificar cuántos amigos cumplen años en ese mes:");
int mesBusqueda = Convert.ToInt32(Console.ReadLine());

int amigosEnMes = 0;

foreach (Amigo amigo in amigos)
{
    if (amigo.Mes == mesBusqueda)
    {
        amigosEnMes++;
        Console.WriteLine($"{amigo.Nombre} cumple años el día {amigo.Dia} del mes {amigo.Mes}.");
    }
}

Console.WriteLine($"\nTotal de amigos que cumplen años en el mes {mesBusqueda}: {amigosEnMes}");

