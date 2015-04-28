using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATM.Modelo;

namespace ATM.DAO
{
    class PersonaDAO : DaoAbstractoSingleton<PersonaDAO>, Interface_DAO<Persona>
    {
        public bool Agregar(Persona entidad)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Persona DameXId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
