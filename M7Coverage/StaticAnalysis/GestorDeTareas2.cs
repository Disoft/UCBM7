using System;
using System.Collections.Generic;

public class GestorDeTareas2
{
    private List<string> tareas = new List<string>();
    private int contador = 0; // ⚠️ Variable no usada

    // 1. Método con variable sin uso y código muerto
    public void AgregarTarea(string tarea)
    {
        string mensaje = "Agregando tarea..."; // ⚠️ Variable no usada
        return;
        tareas.Add(tarea); // ⚠️ Código nunca alcanzado
    }

    // 2. Método con parámetros no utilizados
    public void EditarTarea(int id, string nuevaTarea)
    {
        Console.WriteLine("Tarea editada."); // ⚠️ No usa ni id ni nuevaTarea
    }

    // 3. Método que puede lanzar excepción sin control
    public void EliminarTarea(string indexTexto)
    {
        int index = int.Parse(indexTexto); // ⚠️ Sin TryParse
        tareas.RemoveAt(index);
    }

    // 4. Método con complejidad ciclomática elevada innecesariamente
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

    // 5. Método con nombre ambiguo y sin documentación
    public void DoStuff()
    {
        tareas.Add("tarea");
        Console.WriteLine("Done."); // ⚠️ Poco descriptivo
    }

    // 6. Método duplicado (mismo comportamiento que otro)
    public void Añadir(string tarea)
    {
        tareas.Add(tarea); // ⚠️ Igual que método anterior
    }

    // 7. Método con vulnerabilidad: contraseña hardcodeada
    public bool VerificarAcceso(string user, string pass)
    {
        if (user == "admin" && pass == "123456") // ⚠️ Contraseña en texto plano
        {
            return true;
        }
        return false;
    }
}