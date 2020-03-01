using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_WinForms_RDLC
{
    public class Persona
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public Persona(int ID, string Nombre)
        {
            this.ID = ID;
            this.Nombre = Nombre;
        }
    }

    public class Personas
    {
        public List<Persona> Lista_Persona = new List<Persona>();

        public List<Persona> GetPersonas()
        {
            Lista_Persona.Add(new Persona(1, "Arthur"));
            Lista_Persona.Add(new Persona(2, "Javier"));
            Lista_Persona.Add(new Persona(3, "Jose"));
            Lista_Persona.Add(new Persona(4, "Pepe"));

            return Lista_Persona;
        }
    }
}
