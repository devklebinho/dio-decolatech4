using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_explorando.Models
{
    public class OlhaData
    {
        DateTime data = DateTime.Now;
        string dataString = "2024-20-05 21:57";
        //DateTime dataPersonalizada = DateTime.Parse("23/05/2024 21:54");
        public void MostraDataHora()
        {
            Console.WriteLine(data.ToString("yyyy-MM-dd ° HH:mm"));
        }

        public void MostraData()
        {
            Console.WriteLine(data.ToShortDateString());
        }

        public void MostraHora()
        {
            Console.WriteLine(data.ToShortTimeString());
        }

        public void MostrarDataPersonalizada()
        {
            Console.WriteLine(dataPersonalizada);
        }
    }
}