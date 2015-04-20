namespace ATM.Modelo
{
    public class CuentaDestino
    {
        private int _idcuentaDestino;
        private string _banco;
        private int _cbu;
        private string _sucursal;

        public CuentaDestino(int idcuentaDestino, string banco, int cbu, string sucursal)
        {
            _idcuentaDestino = idcuentaDestino;
            _banco = banco;
            _cbu = cbu;
            _sucursal = sucursal;
        }

        public CuentaDestino()
        {
            _idcuentaDestino = 0;
            _banco = "";
            _cbu = 0;
            _sucursal = "";
        }

        public string Banco
        {
            get { return _banco; }
            set { _banco = value; }
        }
        
        public int Cbu
        {
            get { return _cbu; }
            set { _cbu = value; }
        }
        
        public string Sucursal
        {
            get { return _sucursal; }
            set { _sucursal = value; }
        }

        public int IdcuentaDestino
        {
            get { return _idcuentaDestino; }
            set { _idcuentaDestino = value; }
        }
    }
}
