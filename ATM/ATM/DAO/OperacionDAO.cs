using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATM.Modelo;

namespace ATM.DAO
{
    public class OperacionDAO : DaoAbstractoSingleton<OperacionDAO>, Interface_DAO<Operacion>
    {
        public List<Operacion> ListaOperaciones = new List<Operacion>(); 
        public bool Agregar(Operacion entidad)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Operacion entidad)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(Operacion entidad)
        {
            throw new NotImplementedException();
        }

        public List<Operacion> DameAll()
        {
            throw new NotImplementedException();
        }

        public Operacion DameXId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
