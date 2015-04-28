using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATM.Modelo;

namespace ATM.DAO
{
    class TarjetaDAO : DaoAbstractoSingleton<TarjetaDAO>, Interface_DAO<Tarjeta>
    {
        public List<Tarjeta> ListaTarjetas = new List<Tarjeta>();

        public bool Agregar(Tarjeta entidad)
        {
            ListaTarjetas.Add(entidad);
            return true;
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
            return ListaTarjetas;
        }

        public Tarjeta DameXId(int id)
        {
            foreach (Tarjeta tarjeta in ListaTarjetas)
            {
                if (tarjeta.IdTarjeta == id)
                {
                    return tarjeta;
                }
            }
            return null;
        }
    }
}
