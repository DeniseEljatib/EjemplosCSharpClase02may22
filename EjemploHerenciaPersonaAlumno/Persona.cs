using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploHerenciaPersonaAlumno
{
    class Persona
    {
        public String apellido { get; set; }
        public String nombre { get; set; }
        public int dni { get; set; }

        public Persona()
        {
        }

        public Persona(String apellido, String nombre, int dni)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
        }

        public String retornarDatos()
        {
            return $"{nombre} {apellido} tiene el DNI {dni}";
        }
    }

}
