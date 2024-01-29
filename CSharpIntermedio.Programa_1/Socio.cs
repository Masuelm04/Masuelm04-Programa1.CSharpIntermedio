using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermedio.Programa_1
{
    public class Socio
    {
        private string nombre;
        private int antiguedad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Antiguedad
        {
            get { return antiguedad; }
            set { antiguedad = value; }
        }
        public Socio(string nombre, int antiguedad)
        {
            this.nombre = nombre;
            this.antiguedad = antiguedad;
        }
    }
}
