using primerFormWindows.Entidad;

namespace primerFormWindows.Logica
{
    public interface IReseniaServicio
    {
        void AgregarResenia(Resenia resenia);
        List<Resenia> OtenerResenias();
    }
    public class ReseniaServicio : IReseniaServicio
    {
        private List<Resenia> _listResenia;

        public ReseniaServicio()
        {
            _listResenia = new List<Resenia>();
        }

        public void AgregarResenia(Resenia resenia)
        {
            _listResenia.Add(resenia);
        }

        public List<Resenia> OtenerResenias()
        { return _listResenia; }
    }
}
