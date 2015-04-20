using System;
using System.Collections.Generic;
using System.Reflection;

namespace ATM.Modelo
{
    public class Cliente : Persona
    {
        private List<Cuenta> _listaCuentas;
        private string _situacionImpositiva;
        private List<Tarjeta> _listaTarjetas;

        public Cliente( string situacionImpositiva, int id, string nombre, string apellido, 
            string dni, DateTime fechaNacimiento, string direccion, string telefono, string celular, string mail)
            : base(id, nombre, apellido, dni, fechaNacimiento, mail, direccion, telefono, celular)
        {
            _listaCuentas = null;
            _situacionImpositiva = null;
            _listaTarjetas = null;         
        }
       
        public List<Cuenta> ListaCuentas
        {
            get { return _listaCuentas; }
            set { _listaCuentas = value; }
        }

        public string SituacionImpositiva
        {
            get { return _situacionImpositiva; }
            set { _situacionImpositiva = value; }
        }

        public List<Tarjeta> ListaTarjetas
        {
            get { return _listaTarjetas; }
            set { _listaTarjetas = value; }
        }
    }
}
