﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATM.Modelo;


namespace ATM.DAO
{
    class ClienteDAO :DaoAbstractoSingleton<ClienteDAO>, Interface_DAO<Cliente>
    {
        public bool Agregar(Cliente entidad)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Cliente entidad)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(Cliente entidad)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> DameAll()
        {
            throw new NotImplementedException();
        }

        public Cliente DameXId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
