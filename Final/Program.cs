using Final;

Personaje heroe = new Personaje()
{
    Nombre = "Kael",
    Vida = 100,
    Ataque = 25,
    Defensa = 15,
    Nivel = 1
};

// 2. Imprimir en consola
Console.WriteLine("=== Datos del personaje ===");
Console.WriteLine($"Nombre:  {heroe.Nombre}");
Console.WriteLine($"Vida:    {heroe.Vida}");
Console.WriteLine($"Ataque:  {heroe.Ataque}");
Console.WriteLine($"Defensa: {heroe.Defensa}");
Console.WriteLine($"Nivel:   {heroe.Nivel}");