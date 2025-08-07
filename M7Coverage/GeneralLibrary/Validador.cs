namespace GeneralLibrary
{
    public class Validador
    {
        public string Evaluar(int edad, bool tienePermiso)
        {
            if (edad >= 18)
            {
                if (tienePermiso)
                {
                    return "Aprobado";
                }
                else
                {
                    return "Permiso requerido";
                }
            }
            else
            {
                return "Menor de edad";
            }
        }
    }
}
