using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATM.Modelo;

namespace ATM.DAO
{
    class TipoOperacionDAO : DaoAbstractoSingleton<TipoCuentaDAO>, Interface_DAO<TipoOperacion>
    {
        public bool Agregar(TipoOperacion entidad)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(TipoOperacion entidad)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(TipoOperacion entidad)
        {
            throw new NotImplementedException();
        }

        public List<TipoOperacion> DameAll()
        {
            throw new NotImplementedException();
        }

        public TipoOperacion DameXId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
