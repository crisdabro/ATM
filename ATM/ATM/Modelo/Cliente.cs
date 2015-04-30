using System;
using System.Collections.Generic;
using System.Reflection;

namespace ATM.Modelo
{
    public class Cliente : Persona
    {
        private int _idCliente;
        private string _situacionImpositiva;
        private List<Cuenta> _listaCuentasCliente;
        private List<Tarjeta> _listaTarjetasCliente;

        public Cliente(int idCliente, string situacionImpositiva, List<Cuenta> cuentasCliente, List<Tarjeta> tarjetasCliente,
                       string nombre, string apellido, string dni, DateTime fechaNacimiento, string direccion, string telefono, string celular, string mail): base(idCliente, nombre, apellido, dni, fechaNacimiento, direccion, telefono, celular, mail)
                       
        {
            IdCliente = idCliente;
            SituacionImpositiva = situacionImpositiva;
            ListaCuentas = cuentasCliente;
            ListaTarjetas = tarjetasCliente;         
        }
       
        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        public string SituacionImpositiva
        {
            get { return _situacionImpositiva; }
            set { _situacionImpositiva = value; }
        }
        public List<Cuenta> ListaCuentas
        {
            get { return _listaCuentasCliente; }
            set { _listaCuentasCliente = value; }
        }
        public List<Tarjeta> ListaTarjetas
        {
            get { return _listaTarjetasCliente; }
            set { _listaTarjetasCliente = value; }
        }

    }
}
