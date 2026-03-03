using System;

namespace WinFormsApp2
{
    
    public class Tarea
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool Completada { get; set; }
        public DateTime Fecha { get; set; }

        
        public Tarea(string titulo, string descripcion, DateTime fecha)
        {
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Fecha = fecha;
            this.Completada = false;
        }

        public override string ToString()
        {
            string estado = Completada ? "[X]" : "[ ]";
            return $"{estado} {Titulo} ({Fecha.ToShortDateString()})";
        }
    }
}