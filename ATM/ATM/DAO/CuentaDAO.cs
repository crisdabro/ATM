using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATM.Modelo;

namespace ATM.DAO
{
    class CuentaDAO : Interface_DAO<Cuenta>
    {
        public List<Cuenta> Agregar(List<Cuenta> entidad)
        {
            throw new NotImplementedException();
        }

        public Cuenta Modificar(Cuenta entidad)
        {
            throw new NotImplementedException();
        }

        public void Borrar(Cuenta entidad)
        {
            throw new NotImplementedException();
        }

        public List<Cuenta> DameAll()
        {
            throw new NotImplementedException();
        }

        public Cuenta DameXId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
