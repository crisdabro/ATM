using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.Modelo
{
    public class Persona
    {
        private int _idPropietario;
        private string _nombre;
        private string _apellido;
        private string _dni;
        private DateTime _fechaNacimiento;
        private string _direccion;
        private string _telefono;
        private string _celular;
        private string _mail;

        public Persona()
        {
            IdPropietario = 0;
            Nombre = "";
            Apellido = "";
            Dni = "";
            FechaNacimiento = DateTime.MinValue;
            Direccion = "";
            Telefono = "";
            Celular = "";
            Mail = "";
        }

        public Persona(int idPersona, string nombre, string apellido, string dni, DateTime fechaNacimiento, string direccion, string telefono, string celular, string mail)
        {
            IdPropietario = idPersona;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            FechaNacimiento = fechaNacimiento;
            Direccion = direccion;
            Telefono = telefono;
            Celular = celular;
            Mail = mail;
        }
        
        public int IdPropietario
        {
            get { return _idPropietario; }
            set { _idPropietario = value; }
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
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
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
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

    }
}
