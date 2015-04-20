using System.Collections.Generic;

namespace ATM.Modelo
{
    public class TipoCuenta
    {
        private int _idTipoCuenta;
        private string _nombreTipo;     
        private double _limiteDineroExtraccion;
        private int _limiteCantidadExtracciones;
        private List<Carga> _listaCargos;       
        private List<Impuesto> _listaImpuestos;       
        private List<Comision> _listaComisiones;

        public TipoCuenta(int idTipoCuenta, string nombretipo, double limiteDinero, int limiteCantidadExtracciones, List<Carga> listaCargos, List<Impuesto> listaImpuestos, List<Comision> listaComisiones)
        {
            _idTipoCuenta = IdTipoCuenta;
            _nombreTipo = nombretipo;
            _limiteDineroExtraccion = limiteDinero;
            _limiteCantidadExtracciones = limiteCantidadExtracciones;
            _listaCargos = listaCargos;
            _listaImpuestos = listaImpuestos;
            _listaComisiones = listaComisiones;
        }

        public TipoCuenta()
        {
            _idTipoCuenta = 0;
            _nombreTipo = "";
            _limiteDineroExtraccion = 0.0;
            _limiteCantidadExtracciones = 0;
            _listaCargos = null;
            _listaImpuestos = null;
            _listaComisiones = null;
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
        
        public double LimiteDinero
        {
            get { return _limiteDineroExtraccion; }
            set { _limiteDineroExtraccion = value; }
        }
        
        public int LimiteCantidadExtracciones
        {
            get { return _limiteCantidadExtracciones; }
            set { _limiteCantidadExtracciones = value; }
        }

        public List<Carga> ListaCargos
        {
            get { return _listaCargos; }
            set { _listaCargos = value; }
        }

        public List<Impuesto> ListaImpuestos
        {
            get { return _listaImpuestos; }
            set { _listaImpuestos = value; }
        }

        public List<Comision> ListaComisiones
        {
            get { return _listaComisiones; }
            set { _listaComisiones = value; }
        }
    }
}
