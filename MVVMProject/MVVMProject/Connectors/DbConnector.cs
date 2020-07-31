using MVVMProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMProject.Connectors
{
    public class DbConnector
    {
        public PersonaCollection listarPersonas()
        {
            PersonaCollection lista = new PersonaCollection();
            lista.Add(new Persona(1, "Pedro"));
            lista.Add(new Persona(2, "Juan"));
            lista.Add(new Persona(3, "Diego"));
            lista.Add(new Persona(4, "Luis"));
            return lista;
        }
        
        public bool eliminarPersona(Persona p)
        {
            return true;
        }
    }
}
