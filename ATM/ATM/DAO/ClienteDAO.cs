using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATM.Modelo;


namespace ATM.DAO
{
    class ClienteDAO :DaoAbstractoSingleton<ClienteDAO>, Interface_DAO<Cliente>
    {
        private List<Cliente> listaClientes = new List<Cliente>(); 
        public bool Agregar(Cliente entidad)
        {
            listaClientes.Add(entidad);
            return true;
            
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
            return listaClientes;
        }

        public Cliente DameXId(int id)
        {
            foreach (Cliente cliente in listaClientes)
            {
                if (cliente.IdCliente == id)
                {
                    return cliente;
                }
            }
            return null;
        }
    }
}
