using System;

namespace EjemploHerenciaPersonaAlumno
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("López", "Josefina", 35256854);
            Console.WriteLine(p.retornarDatos());

            Alumno alu1 = new Alumno("Alonso", "Nicolás", 36111444);
            alu1.legajo = 455;
            alu1.examen = new Examen("THP", TipoExamen.FINAL, 8);
            //acá estoy asignando valores desde afuera, totalmente contra las reglas 
            //del encapsulamiento, pero no sé aún cómo hacerlo de otra manera. 

            Alumno alu2 = new Alumno("Loiseau", "Julieta", 52563254);
            alu2.legajo = 555;
            alu2.examen = new Examen("Termodinámica 1", TipoExamen.PARCIAL, 10);

            //Guardo al alumno 3 en la Rama1 únicamente
            Alumno alu3 = new Alumno("Eljatib", "Denise", 35625415);
            alu3.legajo = 456;
            alu3.examen = new Examen("Termodinámica 2", TipoExamen.PARCIAL, 10);
            
            Console.WriteLine(alu1.retornarDatos());
            Console.WriteLine(alu2.retornarDatos());
            Console.WriteLine(alu3.retornarDatos());
            
             




        }
    }
}
