using System.Collections.Generic;

namespace ATM.Modelo
{
    public class TipoCuenta
    {
        private int _idTipoCuenta;
        private string _nombreTipo;     
        private double _limiteExtraccionDinero;
        private int _limiteCantidadExtracciones;
        private double _limiteDeposito;
        //private List<Carga> _listaCargos;       
        //private List<Impuesto> _listaImpuestos;       
        //private List<Comision> _listaComisiones;

        public TipoCuenta(int idTipoCuenta, string nombretipo, double limiteDinero, int limiteCantidadExtracciones, double limiteDeposito) // , List<Carga> listaCargos, List<Impuesto> listaImpuestos, List<Comision> listaComisiones)
        {
            IdTipoCuenta = idTipoCuenta;
            NombreTipo = nombretipo;
            LimiteExtraccionDinero = limiteDinero;
            LimiteCantidadExtracciones = limiteCantidadExtracciones;
            LimiteDeposito = limiteDeposito;
            //_listaCargos = listaCargos;
            //_listaImpuestos = listaImpuestos;
            //_listaComisiones = listaComisiones;
        }

        public TipoCuenta()
        {
            IdTipoCuenta = 0;
            NombreTipo = "";
            LimiteExtraccionDinero = 0.0;
            LimiteCantidadExtracciones = 0;
            LimiteDeposito = 0.0;
            //_listaCargos = null;
            //_listaImpuestos = null;
            //_listaComisiones = null;
        }

        public int IdTipoCuenta
        {
            get { return _idTipoCuenta; }
            set { _idTipoCuenta = value; }
        }
        
        public string NombreTipo
        {
            get { return _nombreTipo; }
            set { _nombreTipo = value; }
        }
        
        public double LimiteExtraccionDinero
        {
            get { return _limiteExtraccionDinero; }
            set { _limiteExtraccionDinero = value; }
        }
        
        public int LimiteCantidadExtracciones
        {
            get { return _limiteCantidadExtracciones; }
            set { _limiteCantidadExtracciones = value; }
        }

        public double LimiteDeposito
        {
            get { return _limiteDeposito; }
            set { _limiteDeposito = value; }
        }


        //public List<Carga> ListaCargos
        //{
        //    get { return _listaCargos; }
        //    set { _listaCargos = value; }
        //}

        //public List<Impuesto> ListaImpuestos
        //{
        //    get { return _listaImpuestos; }
        //    set { _listaImpuestos = value; }
        //}

        //public List<Comision> ListaComisiones
        //{
        //    get { return _listaComisiones; }
        //    set { _listaComisiones = value; }
        //}
    }
}
