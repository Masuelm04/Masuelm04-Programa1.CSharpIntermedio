using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermedio.Programa_1
{
    public class Club
    {
        private string? nombre { get; set; }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Socio[] socios = new Socio[3];

        public Club(string nombre, Socio[] socios)
        {
            this.socios = socios;
            this.Nombre = nombre;
        }

        public void ImprimirSocioMasAntiguo()
        {
            Socio socioMasAntiguio = socios[0];

            for (int i = 0; i < socios.Length; i++)
            {
                if (socios[i].Antiguedad > socioMasAntiguio.Antiguedad)
                {
                    socioMasAntiguio = socios[i];
                }
            }

            Console.WriteLine($"El socio con mayor tiempo en el club \"{nombre}\" es: {socioMasAntiguio.Nombre}");
        }
    }
}
