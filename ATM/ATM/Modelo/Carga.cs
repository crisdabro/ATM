namespace ATM.Modelo
{
    public class Carga
    {
        private int _idCargo;
        private string _descripcion;
        private double _valor;
        private string _frecuenciaCobro;

        public Carga(int idImpuesto, string descripcion, double valor, string frecuenciaCobro)
        {
            _idCargo = idImpuesto;
            _descripcion = descripcion;
            _valor = valor;
            _frecuenciaCobro = frecuenciaCobro;
        }

        public Carga()
        {
            _idCargo = 0;
            _descripcion = "";
            _valor = 0.0;
            _frecuenciaCobro = "";
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public string FrecuenciaCobro
        {
            get { return _frecuenciaCobro; }
            set { _frecuenciaCobro = value; }
        }

        public int IdCargo
        {
            get { return _idCargo; }
            set { _idCargo = value; }
        }
    }
}
