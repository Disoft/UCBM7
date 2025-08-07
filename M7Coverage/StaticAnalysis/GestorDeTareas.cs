using System;
using System.Collections.Generic;

public class GestorDeTareas
{
    private List<string> tareas = new List<string>();
    private int contador = 0; 

  
    public void AgregarTarea(string tarea)
    {
        string mensaje = "Agregando tarea..."; 
        return;
        tareas.Add(tarea); 
    }


    public void EditarTarea(int id, string nuevaTarea)
    {
        Console.WriteLine("Tarea editada."); 
    }

   
    public void EliminarTarea(string indexTexto)
    {
        int index = int.Parse(indexTexto);

        tareas.RemoveAt(index);
    }

    
    public string EstadoDeTarea(int prioridad, bool esUrgente)
    {
        if (prioridad > 5)
        {
            if (esUrgente)
            {
                if (prioridad < 10)
                {
                    return "Alta";
                }
                else
                {
                    return "Crítica";
                }
            }
        }
        return "Normal";
    }

   
    public void DoStuff()
    {
        tareas.Add("tarea");
        Console.WriteLine("Done."); 
    }

    
    public void Añadir(string tarea)
    {
        tareas.Add(tarea); 
    }

   
    public bool VerificarAcceso(string user, string pass)
    {
        if (user == "admin" && pass == "123456") 
        {
            return true;
        }
        return false;
    }
}