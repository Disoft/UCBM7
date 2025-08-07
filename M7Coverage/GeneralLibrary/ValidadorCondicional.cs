namespace GeneralLibrary
{
    public class ValidadorCondicional
    {
        public string EvaluarAcceso(bool tienePermiso, bool esAdministrador)
        {
            if (tienePermiso && esAdministrador)
            {
                return "Acceso concedido";
            }
            else
            {
                return "Acceso denegado";
            }
        }
    }
}
