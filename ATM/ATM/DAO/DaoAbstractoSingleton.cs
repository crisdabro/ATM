using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.DAO
{
    public abstract class DaoAbstractoSingleton<D> where D : DaoAbstractoSingleton<D>, new()
    {
        private static D _instancia;

        public static D instancia()
        {
            if (_instancia == null)
            { _instancia = new D(); }
            return _instancia;
        }
    }
}
