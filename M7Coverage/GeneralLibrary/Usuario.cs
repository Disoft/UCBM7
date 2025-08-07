namespace GeneralLibrary
{
    public class Usuario
    {
        public string Nombre { get; set; }

        public int CalcularEdad(string fechaNacimiento)
        {
            DateTime nacimiento = DateTime.Parse(fechaNacimiento); // puede lanzar excepción
            int edad = DateTime.Now.Year - nacimiento.Year;

            if (DateTime.Now.DayOfYear < nacimiento.DayOfYear)
                edad--;

            return edad;
        }
    }
}
