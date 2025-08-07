namespace StaticAnalysis
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool Activo = true; 
        public bool EsMayorDeEdad()
        {
            if (Edad >= 18)
                return true;
            else
                return false; 
        }
    }
}
