namespace primerFormWindows.Entidad
{
    public class Resenia
    {
        public string Fecha {  get; set; }
        public string Direccion { get; set; }
        public string TipoLocal { get; set; }
        public string Puntuacion { get; set; }

        public Resenia(string fecha, string direccion, string tipoLocal, string puntuacion) 
        { 
            Fecha = fecha;
            Direccion = direccion;
            TipoLocal = tipoLocal;
            Puntuacion = puntuacion;
        }

    }
}
