using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.DAO
{
    public interface Interface_DAO<T>
    {
        bool Agregar(T entidad);
        bool Modificar(T entidad);
        bool Borrar(T entidad);
        List<T> DameAll();
        T DameXId(int id);
    }
}
