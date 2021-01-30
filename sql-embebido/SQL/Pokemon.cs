using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql_embebido.SQL
{
    class Pokemon
    {
        private string id;
        private string mote;
        private string nivel;
        private string entrenador;

        public Pokemon()
        {
            id = "";
            mote = "";
            nivel = "";
            entrenador = "";
        }

        public Pokemon(string id, string mote, string nivel, string entrenador)
        {
            this.id = id;
            this.mote = mote;
            this.nivel = nivel;
            this.entrenador = entrenador;
        }

        public string getId()
        {
            return id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public string getMote()
        {
            return mote;
        }

        public void setMote(string mote)
        {
            this.mote = mote;
        }

        public string getNivel()
        {
            return nivel;
        }

        public void setNivel(string nivel)
        {
            this.nivel = nivel;
        }

        public string getEntrenador()
        {
            return entrenador;
        }

        public void setEntrenador(string entrenador)
        {
            this.entrenador = entrenador;
        }
    }
}
