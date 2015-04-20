using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.DAO
{
    public interface Interface_DAO<T>
    {
        List<T> Agregar(List<T> entidad);
        T Modificar(T entidad);
        void Borrar(T entidad);
        List<T> DameAll();
        T DameXId(string id);
    }
}
