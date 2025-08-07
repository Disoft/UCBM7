namespace GeneralLibrary
{
    public class EnvioService
    {
        public string DeterminarTipoEnvio(bool esUrgente, bool esInternacional)
        {
            if (esUrgente && esInternacional)
                return "Exprés Internacional";
            else if (esUrgente)
                return "Exprés Nacional";
            else if (esInternacional)
                return "Normal Internacional";
            else
                return "Normal Nacional";
        }
    }

    

}
