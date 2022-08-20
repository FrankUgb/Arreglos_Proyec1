using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Estructura
{
    class Program
    {
        static void Main(string[] args)
        {
            int espacios;
            Console.WriteLine("Digite la cantidad de espacios para el arreiglo");
            espacios = int.Parse(Console.ReadLine());

            string[] nombre = new string[espacios];
            string[] carrera = new string[espacios];
            string[] facultad = new string[espacios];
            int[] edad = new int[espacios];
            string[] gmail = new string[espacios];
            int[] telefono = new int[espacios];

            for (int i = 0; i < espacios; i++)
            {
                Console.WriteLine("Ingrese su nombre");
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese su carrera");
                carrera[i] = Console.ReadLine();
                Console.WriteLine("Ingrese su facultad");
                facultad[i] = Console.ReadLine();
                Console.WriteLine("Ingrese su edad");
                edad[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su gmail");
                gmail[i] = Console.ReadLine();
                Console.WriteLine("Ingrese su telefono");
                telefono[i] = int.Parse(Console.ReadLine());

            }

            for (int i=0; i < espacios; i++)
            {
                Console.Write("Nombre: " + nombre[i]+ " | ");
                Console.Write("Carrera: " + carrera[i] + " | ");
                Console.Write("Facultad: " + facultad[i] + " | ");
                Console.Write("Edad " + edad[i] + " | ");
                Console.Write("Gmail: " + gmail[i] + " |");
                Console.Write("Telefono: " + telefono[i] + " | \n");

            }
        }
    }
}