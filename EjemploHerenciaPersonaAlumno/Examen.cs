namespace EjemploHerenciaPersonaAlumno
{
    public class Examen
    {

        public string materia { get; set; }

        public TipoExamen tipo { get; set; }

        public int nota { get; set; }

        public Examen(string materia, TipoExamen tipo, int nota)
        {
            this.materia = materia;
            this.tipo = tipo;
            this.nota = nota;
        }

    }
}