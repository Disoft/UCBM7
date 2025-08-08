namespace GeneralLibrary.BlackBox.Particionamiento
{
    public class UsuarioBlackBox
    {
        public bool PuedeRegistrarse(int edad)
        {
            return edad >= 18 && edad <= 65;
        }
    }
}