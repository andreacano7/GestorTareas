using System;
using System.Collections.Generic;

namespace WinFormsApp2
{
    
    internal class GestorTareas
    {
        private List<Tarea> listaTareas;

        public GestorTareas()
        {
            listaTareas = new List<Tarea>();
        }

        
        public void AgregarTarea(Tarea nuevaTarea)
        {
            listaTareas.Add(nuevaTarea);
        }

       
        public void EliminarTarea(Tarea tareaAEliminar)
        {
            if (tareaAEliminar != null)
            {
                listaTareas.Remove(tareaAEliminar);
            }
        }

       
        public List<Tarea> ObtenerTodas()
        {
            return listaTareas;
        }
    }
}