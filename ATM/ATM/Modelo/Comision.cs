namespace ATM.Modelo
{
    public class Comision
    {
        private int _idComision;
        private string _descripcion;
        private double _valor;
        private string _frecuenciaCobro;

        public Comision(int idImpuesto, string descripcion, double valor, string frecuenciaCobro)
        {
            _idComision = idImpuesto;
            _descripcion = descripcion;
            _valor = valor;
            _frecuenciaCobro = frecuenciaCobro;
        }

        public Comision()
        {
            _idComision = 0;
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

        public int IdComision
        {
            get { return _idComision; }
            set { _idComision = value; }
        }
    }
}
