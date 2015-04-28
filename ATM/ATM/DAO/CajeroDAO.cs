using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATM.Modelo;
using System.Data.SqlClient;
using System.Data;

namespace ATM.DAO
{
    class CajeroDAO:DaoAbstractoSingleton<CajeroDAO>, Interface_DAO<Cajero>
    {
       
        public List<Cajero> ListaCajeros = new List<Cajero>(); 
        public bool Agregar(Cajero entidad)
        {
            ListaCajeros.Add(entidad);
            return true;
            /*ConnectBDD.Conectar();
            SqlCommand cmd = new SqlCommand("insert into Cajeros(pk_cajero,dinero_disponible,papel_disponible) values(@pk_cajero,@dinero_disponible,@papel_disponible)", ConnectBDD.Connection);
            cmd.Parameters.AddWithValue("@pk_cajero", entidad.IdCajero);
            cmd.Parameters.AddWithValue("@dinero_disponible", entidad.Dinerodisponible);
            cmd.Parameters.AddWithValue("@papel_disponible", entidad.Papeldisponible);
            cmd.ExecuteReader();
            ConnectBDD.Desconectar();
            throw new NotImplementedException();*/
        }

        public bool Modificar(Cajero entidad)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(Cajero entidad)
        {
            throw new NotImplementedException();
        }

        public List<Cajero> DameAll()
        {
            return ListaCajeros;
        }

       /* public Cajero DameXId(int id)
        {
            foreach (var caj in ListaCajeros)
            {

                
            }
            (int i = 0; i < ListaCajeros.Count; i++)
            {
                if (ListaCajeros[i].IdCajero == id)
                {
                    return ListaCajeros[i];
                }
                
            }
        }*/
    }
}
