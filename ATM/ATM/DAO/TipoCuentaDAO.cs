using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATM.Modelo;

namespace ATM.DAO
{
    class TipoCuentaDAO : DaoAbstractoSingleton<TipoCuentaDAO>, Interface_DAO<TipoCuenta>
    {
        public bool Agregar(TipoCuenta entidad)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(TipoCuenta entidad)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(TipoCuenta entidad)
        {
            throw new NotImplementedException();
        }

        public List<TipoCuenta> DameAll()
        {
            throw new NotImplementedException();
        }

        public TipoCuenta DameXId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
