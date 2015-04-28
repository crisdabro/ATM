using System.Collections.Generic;

namespace ATM.Modelo
{
    public class TipoOperacion
    {
        private int _idTipoOperacion;      
        private string _nombre;
        private double _costo;
        /*private List<Carga> _listaCargos;        
        private List<Impuesto> _listaImpuestos;       
        private List<Comision> _listaComisiones;*/     

        public TipoOperacion(int idTipoOperacion, string nombre, double costo/*, List<Carga> listaCargos, List<Impuesto> listaImpuestos, List<Comision> listaComisiones*/)
        {
            _idTipoOperacion = idTipoOperacion;
            _nombre = nombre;
            _costo = costo;
           /*_listaCargos = listaCargos;
            _listaImpuestos = listaImpuestos;
            _listaComisiones = listaComisiones;*/      
        }

        public TipoOperacion()
        {
            _idTipoOperacion = 0;
            _nombre = "";
            _costo = 0.0;
            /*_listaCargos = null;
            _listaImpuestos = null;
            _listaComisiones = null;*/
        }

        public int IdTipoOperacion
        {
            get { return _idTipoOperacion; }
            set { _idTipoOperacion = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
        public double Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }

        /*public List<Carga> ListaCargos
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
        }*/

    }
}
