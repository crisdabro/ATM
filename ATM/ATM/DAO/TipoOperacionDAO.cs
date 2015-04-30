using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATM.Modelo;

namespace ATM.DAO
{
    class TipoOperacionDAO : DaoAbstractoSingleton<TipoCuentaDAO>, Interface_DAO<TipoOperacion>
    {
        public List<TipoOperacion> ListaCompletaTipoOperaciones = new List<TipoOperacion>();
        public bool Agregar(TipoOperacion entidad)
        {
            ListaCompletaTipoOperaciones.Add(entidad);
            return true;
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
            foreach (TipoOperacion tipoOperacion in ListaCompletaTipoOperaciones)
            {
                if (tipoOperacion.IdTipoOperacion == id)
                {
                    return tipoOperacion;
                }
            }
            return null;
        }

        public TipoOperacion DameXId(string nombre)
        {
            foreach (TipoOperacion tipoOperacion in ListaCompletaTipoOperaciones)
            {
                if (tipoOperacion.Nombre == nombre)
                {
                    return tipoOperacion;
                }
            }
            return null;
        }
    }
}
