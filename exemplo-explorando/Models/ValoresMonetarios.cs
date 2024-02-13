using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace exemplo_explorando.Models
{
    public class ValoresMonetarios
    {
        decimal valorMonetario = 30.46M;
        double percent = .3421;
        int numero = 123456;

        public void MostrarValores()
        {
            Console.WriteLine($"{valorMonetario:C}");//
            //Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(valorMonetario.ToString("C8"));//exibe 8 casas decimais


            Console.WriteLine(percent.ToString("P"));

            Console.WriteLine(numero.ToString("##-##-##"));
        }

    }
}