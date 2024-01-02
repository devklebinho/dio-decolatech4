using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Tasks;

namespace exemplo_fundamentos.Models
{
    //Formas de declarar um array:
    //int[] array = new int[4]; -> declara um array com limite de índices
    //int[] array = new int[]{32, 55, 67}; -> omite-se o tamanho e inicializa os valores
    //string[] nomes = {"juliana", "prizza"}; -> inicializa os valores de forma direta
    public class ArrayEListas
    {

        public void ExecutaArray()
        {
            int[] arrayInteiros = new int[4];
            arrayInteiros[0] = 34;
            arrayInteiros[1] = 45;
            arrayInteiros[2] = 87;
            arrayInteiros[3] = 90;

            int[] arrayIntDobrado = new int[arrayInteiros.Length * 2];
            // o último parâmetro refere-se à quantos elementos vc deseja copiar
            Array.Copy(arrayInteiros, arrayIntDobrado, arrayInteiros.Length); 

            //Resizing array length
            //Array.Resize(ref arrayInteiros, arrayInteiros.Length *2);

            for (int cont=0; cont <arrayInteiros.Length; cont++)
            {
                Console.WriteLine($"indice {cont} = {arrayInteiros[cont]}");
            }

            foreach(int valor in arrayInteiros)
            {
                Console.WriteLine($"Valor: {valor}");
            }
        }

        public void ExecutaLista()
        {
            //Uma lista é um Array dinâmico
            List<string> listaNomes = new List<string>();

            listaNomes.Add("Priscilla");
            listaNomes.Add("Marília");
            listaNomes.Add("Marcelo");
            listaNomes.Add("Boneco Josias");

            Console.WriteLine("Percorrendo o a lista com o FOR");
            for(int i=0; i <listaNomes.Count; i++)
            {
                Console.WriteLine($"Incide {i} = {listaNomes[i]}");
            }

            Console.WriteLine($"Itens na lista: {listaNomes.Count}\n",
                            $"Capacidade: {listaNomes.Capacity}");

            listaNomes.Remove("Boneco Josias");

            Console.WriteLine("Percorrendo o a lista com o FOREACH");
            //mais recomendado para percorrer listas
            foreach(string nome in listaNomes)
            {
                Console.WriteLine(nome);
            }

        }
        
    }
}