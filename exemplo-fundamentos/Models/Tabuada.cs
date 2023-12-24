using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_fundamentos.Models
{
    public class Tabuada
    {
        public void CriaTabuada(int numero)
        {
            int contador = 0;
            while(contador <= 10)
            {
                Console.WriteLine($"{contador} x {numero} = {contador*numero}");
                contador++;
            }
            // for(int i = 0; i <= 10; i++)
            // {
            //     Console.WriteLine($"{i} x {j} = {i*j}");
            // }

        }
    }
}