using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaNo1_4_Problema3
{
    public class Club
    {
        static void Main(string[] args)
        {
            clsSocio[] Socio = new clsSocio[3];
            Socio[0] = new clsSocio("José Peguero", 12);
            Socio[1] = new clsSocio("Carlos Ureña", 18);
            Socio[2] = new clsSocio("Pedro Bobea", 15);

            int IndiceMayorAntiguedad = 0;
            int MayorAntiguedad = 0;

            for (int i = 0; i <= 2; i++)
            {
                if (Socio[i].RetornarAntiguedad() > MayorAntiguedad)
                {
                    IndiceMayorAntiguedad = i;
                    MayorAntiguedad = Socio[i].RetornarAntiguedad();
                }

            }
            Console.WriteLine($"El Socio '{Socio[IndiceMayorAntiguedad].RetornarNombre()}' tiene mayor antiguedad en el club.");
        }
    }
}
