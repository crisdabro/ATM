using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATM.Modelo;

namespace ATM.DAO
{
    class ImpuestoDAO : DaoAbstractoSingleton<ImpuestoDAO>, Interface_DAO<Impuesto>
    {
        public bool Agregar(Impuesto entidad)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Impuesto entidad)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(Impuesto entidad)
        {
            throw new NotImplementedException();
        }

        public List<Impuesto> DameAll()
        {
            throw new NotImplementedException();
        }

        public Impuesto DameXId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
