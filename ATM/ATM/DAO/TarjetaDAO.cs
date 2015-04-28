using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATM.Modelo;

namespace ATM.DAO
{
    class TarjetaDAO : DaoAbstractoSingleton<TarjetaDAO>, Interface_DAO<Tarjeta>
    {
        public bool Agregar(Tarjeta entidad)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Tarjeta entidad)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(Tarjeta entidad)
        {
            throw new NotImplementedException();
        }

        public List<Tarjeta> DameAll()
        {
            throw new NotImplementedException();
        }

        public Tarjeta DameXId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
