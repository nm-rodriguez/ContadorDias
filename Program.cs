// See https://aka.ms/new-console-template for more information


double diferencia = 0;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WindowWidth = 60;
Console.WindowHeight = 15;

    
do
{
    try
    {
        Console.Clear();
        Console.WriteLine("Ingrese desde que fecha:");
        DateTime fecha = DateTime.Parse(Console.ReadLine());
        //DateTime fecha = new(2022,05,09,00,40,00);
        Console.WriteLine("Ingrese hasta que fecha");
        diferencia = ((DateTime.Parse(Console.ReadLine()) - fecha).TotalHours) / 24;
        //diferencia = ((DateTime.Now - fecha).TotalHours) / 24;
        Console.WriteLine($"Dias desde esa fecha: {diferencia}");

    }
    catch (Exception)
    {
        Console.WriteLine("La fecha ingresada no es valida.");
        
    }
   
    Console.WriteLine("q     -> salir\nenter -> nuevo intento");

} while (Console.ReadLine() != "q");
