using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();

            Console.WriteLine("Alumno 1:");
            Console.WriteLine("Nombre: " + alumno1.Nombre);
            Console.WriteLine("Matricula: " + alumno1.Matricula);

            //SSA EL CONSTRUCTOR SIN PARAMETROS
            //DESPUES ESTABLECE SUS

            Alumno alumno2 = new Alumno();

            Console.WriteLine("Alumno 2:");
            Console.WriteLine("Nombre: " + alumno2.Nombre);
            Console.WriteLine("Matricula: " + alumno2.Matricula);

            alumno2.Nombre = "Pedro";
            alumno2.Matricula = "ABC123";

            Console.WriteLine("Alumno 2:");
            Console.WriteLine("Nombre: " + alumno2.Nombre);
            Console.WriteLine("Matricula: " + alumno2.Matricula);

            Alumno alumno3 = new Alumno("Ana", "XYZ543");

            Console.WriteLine("Alumno 3:");
            Console.WriteLine("Nombre: " + alumno3.Nombre);
            Console.WriteLine("Matricula: " + alumno3.Matricula);

            Console.Read();
        }
    }
}
