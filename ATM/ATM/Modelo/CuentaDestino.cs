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
            IdcuentaDestino = idcuentaDestino;
            Banco = banco;
            Cbu = cbu;
            Sucursal = sucursal;
        }

        public CuentaDestino()
        {
            IdcuentaDestino = 0;
            Banco = "";
            Cbu = 0;
            Sucursal = "";
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
