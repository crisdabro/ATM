using ATM.DAO;
namespace ATM.Modelo
{
    public class Cajero
    {
         
        private int _idCajero;
        private double _dineroDisponible;
        private double _dineroDepositado;
        private int _papelDisponible;

        public Cajero(int idCajero, double dinero, int papel)
        {
            _idCajero = idCajero;
            _dineroDisponible = dinero;

            _papelDisponible = papel;
        }

        public Cajero()
        {
            _idCajero = 0;
            _dineroDisponible = 0.0;
            _papelDisponible = 0;
        }

        public double Dinerodisponible
        {
            get { return _dineroDisponible; }
            set { _dineroDisponible = value; }
        }
        
        public int Papeldisponible
        {
            get { return _papelDisponible; }
            set { _papelDisponible = value; }
        }

        public int IdCajero
        {
            get { return _idCajero; }
            set { _idCajero = value; }
        }

        public double DineroDepositado
        {
            get { return _dineroDepositado; }
            set { _dineroDepositado = value; }
        }

        //////////////////////////////////////////////////////// METODOS PARA ALMACENAMIENTO CON DAO DE LA CLASE //////////////////////////////////////////
        
        

        //////////////////////////////////////////////////////// METODOS PARA ALMACENAMIENTO CON DAO DE LA CLASE //////////////////////////////////////////
    }
}
