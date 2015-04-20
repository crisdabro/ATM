namespace ATM.Modelo
{
    public class Impuesto
    {
        private int _idImpuesto;
        private string _descripcion;
        private string _entidad;
        private double _valor;
        private string _frecuenciaCobro;

        public Impuesto(int idImpuesto,string descripcion, string entidad, double valor, string frecuenciaCobro)
        {
            _idImpuesto = idImpuesto;
            _descripcion = descripcion;
            _entidad = entidad;
            _valor = valor;
            _frecuenciaCobro = frecuenciaCobro;
        }

        public Impuesto()
        {
            _idImpuesto = 0;
            _descripcion = "";
            _entidad = "";
            _valor = 0.0;
            _frecuenciaCobro = "";
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public string Entidad
        {
            get { return _entidad; }
            set { _entidad = value; }
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

        public int IdImpuesto
        {
            get { return _idImpuesto; }
            set { _idImpuesto = value; }
        }
    }
}
