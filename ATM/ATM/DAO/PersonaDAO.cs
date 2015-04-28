using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATM.Modelo;

namespace ATM.DAO
{
    class PersonaDAO : DaoAbstractoSingleton<PersonaDAO>, Interface_DAO<Persona>
    {
        public List<Persona> ListaPersonas = new List<Persona>();

        public bool Agregar(Persona entidad)
        {
            ListaPersonas.Add(entidad);
            return true;
        }

        public bool Modificar(Persona entidad)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(Persona entidad)
        {
            throw new NotImplementedException();
        }

        public List<Persona> DameAll()
        {
            return ListaPersonas;
        }

        public Persona DameXId(int id)
        {
            foreach (Persona persona in ListaPersonas)
            {
                if (persona.IdPersona == id)
                {
                    return persona;
                }
            }
            return null;
        }
    }
}
