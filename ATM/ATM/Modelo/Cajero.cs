using ATM.DAO;
namespace ATM.Modelo
{
    public class Cajero
    {        
        private int _idCajero;
        private double _dineroDisponible;
        private int _papelDisponible;
        private int _limiteDepositos;
        private int _cantidadDepositosActuales;

        public Cajero(int idCajero, double dinero, int papel, int cantidadDepositosActuales, int limiteDepositos)
        {
            _idCajero = idCajero;
            _dineroDisponible = dinero;
            _papelDisponible = papel;
            _cantidadDepositosActuales = cantidadDepositosActuales;
            _limiteDepositos = limiteDepositos;
        }

        public Cajero()
        {
            _idCajero = 0;
            _dineroDisponible = 0.0;
            _papelDisponible = 0;
            _cantidadDepositosActuales = 0;
            _limiteDepositos = 200;
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

        public int LimiteDepositos
        {
            get { return _limiteDepositos; }
            set { _limiteDepositos = value; }
        }

        public int CantidadDepositosActuales
        {
            get { return _cantidadDepositosActuales; }
            set { _cantidadDepositosActuales = value; }
        }

        //////////////////////////////////////////////////////// METODOS PARA ALMACENAMIENTO CON DAO DE LA CLASE //////////////////////////////////////////
        
        

        //////////////////////////////////////////////////////// METODOS PARA ALMACENAMIENTO CON DAO DE LA CLASE //////////////////////////////////////////
    }
}
