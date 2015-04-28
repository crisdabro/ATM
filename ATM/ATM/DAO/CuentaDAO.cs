using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATM.Modelo;

namespace ATM.DAO
{
    class CuentaDAO : DaoAbstractoSingleton<CuentaDAO>, Interface_DAO<Cuenta>
    {
        public bool Agregar(Cuenta entidad)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Cuenta entidad)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(Cuenta entidad)
        {
            throw new NotImplementedException();
        }

        public List<Cuenta> DameAll()
        {
            throw new NotImplementedException();
        }

        public Cuenta DameXId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
