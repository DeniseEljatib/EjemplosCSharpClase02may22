using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace EjemploHerenciaPersonaAlumno
{
    class Alumno : Persona
    {

        public int legajo { get; set; }

        public Examen examen { get; set; }

        public Alumno(string apellido, string nombre, int dni)

        {
            base.apellido = apellido;
            base.nombre = nombre;
            base.dni = dni;
        }

        //sobreescritura de un método en una clase derivada:
        public new String retornarDatos()
        {
            return "El alumno " + base.retornarDatos() + $" legajo {legajo} Materia {examen.materia} Examen {examen.tipo} Nota {examen.nota} ";
        }

    }

}

