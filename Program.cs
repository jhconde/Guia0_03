using System;

class Program
{
    static void Main()
    {
        // Definir una variable para almacenar las frases ingresadas por el usuario
        string frase;

        Console.WriteLine("Ingrese frases, escriba 'fin' para terminar.");

        // Utilizar un bucle do-while para permitir al usuario ingresar frases hasta que escriba "fin"
        do
        {
            // Solicitar al usuario que ingrese una frase
            Console.Write("Frase: ");
            frase = Console.ReadLine();

            // Verificar si el usuario ha ingresado "fin" para salir del bucle
        } while (!frase.ToLower().Equals("fin"));

        Console.WriteLine("Programa finalizado.");
    }
}
