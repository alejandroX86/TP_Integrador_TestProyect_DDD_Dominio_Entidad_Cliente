using System;


namespace Dominio_DDD_Entidad_Cliente
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Trabajo Practico de Laboratorio de Software");
            Console.WriteLine("Proyecto Hotel: Prueba Unitaria Dominio Entidad Cliente");
            Console.WriteLine();
            Console.WriteLine("Profesor: Daniel Alejandro Fernandez");
            Console.WriteLine("Alumnos: Julia Avalos");
            Console.WriteLine("         Leonardo Caceres");
            Console.WriteLine("         Eduardo Arizza");
            Console.WriteLine("         Gonzalo Arizza");
            Console.WriteLine("         Omar Bazar");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();


            // Crear un cliente de ejemplo
            Guid id = Guid.NewGuid();
            string nombre = "John Doe";
            string email = "john.doe@example.com";
            string clave = "password123";
            DateTime fechaNacimiento = new DateTime(1990, 1, 1);

            var cliente = new Cliente(id, nombre, email, clave, fechaNacimiento);

        }
    }
}
