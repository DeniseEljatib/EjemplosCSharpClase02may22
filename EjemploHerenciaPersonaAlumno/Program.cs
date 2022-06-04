using System;

namespace EjemploHerenciaPersonaAlumno
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Eljatib", "Denise", 27659741);
            Console.WriteLine(p.retornarDatos());

            Alumno alu = new Alumno("Alonso", "Nicolás", 32756502);
            alu.legajo = 455;
            alu.examen = new Examen("THP", TipoExamen.FINAL, 8);
            //acá estoy asignando valores desde afuera, totalmente contra las reglas 
            //del encapsulamiento, pero no sé aún cómo hacerlo de otra manera. 

            Console.WriteLine(alu.retornarDatos());
        }
    }
}
