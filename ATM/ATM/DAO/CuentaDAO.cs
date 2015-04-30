using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATM.Modelo;

namespace ATM.DAO
{
    class CuentaDAO : DaoAbstractoSingleton<CuentaDAO>, Interface_DAO<Cuenta>
    {
        public List<Cuenta> ListaCompletaCuentas = new List<Cuenta>(); 

        public bool Agregar(Cuenta entidad)
        {
            ListaCompletaCuentas.Add(entidad);
            return true;
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
            return ListaCompletaCuentas;
        }

        public Cuenta DameXId(int id)
        {
            foreach (Cuenta cuenta in ListaCompletaCuentas)
            {
                if (cuenta.Cbu == id)
                {
                    return cuenta;
                }
            }
            return null;
        }
    }
}
