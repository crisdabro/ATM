using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.Modelo
{
    public class Persona
    {
        private int _idPersona;      
        private string _nombre;
        private string _apellido;
        private string _dni;
        private DateTime _fechaNacimiento;
        private string _mail;
        private string _direccion;
        private string _telefono;
        private string _celular;
        
        public Persona(int idPersona, string nombre, string apellido, string dni, DateTime fechaNacimiento, string mail, string direccion, string telefono, string celular)
        {
            _idPersona = idPersona;
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _fechaNacimiento = fechaNacimiento;
            _mail = mail;
            _direccion = direccion;
            _telefono = telefono;
            _celular = celular;
            
        }
        public Persona()
        {
            _idPersona = 0;
            _nombre = "";
            _apellido = "";
            _dni = "";
            _fechaNacimiento = DateTime.MinValue;
            _mail = "";
            _telefono = "";
            _celular = "";

        }

        public int IdPersona
        {
            get { return _idPersona; }
            set { _idPersona = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public DateTime Fechanacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
    }
}
