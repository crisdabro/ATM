using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATM.Modelo;

namespace ATM.DAO
{
    class TipoCuentaDAO : DaoAbstractoSingleton<TipoCuentaDAO>, Interface_DAO<TipoCuenta>
    {
        public List<TipoCuenta> ListaCompletaTipoCuentas = new List<TipoCuenta>();

        public bool Agregar(TipoCuenta entidad)
        {
            ListaCompletaTipoCuentas.Add(entidad);
            return true;
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
            return ListaCompletaTipoCuentas;
        }

        public TipoCuenta DameXId(int id)
        {
            foreach (TipoCuenta tipo in ListaCompletaTipoCuentas)
            {
                if (tipo.IdTipoCuenta == id)
                {
                    return tipo;
                }
            }
            return null;
        }
    }
}
