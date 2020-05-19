using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaIdadePessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            string getout;
            int idade;
            List<int> listaidade = new List<int>();

            do
            {
                Console.WriteLine("Informe a sua idade: ");
                getout = Console.ReadLine();
                if (getout == "sair")
                    break;
                else
                {
                    idade = Convert.ToInt32(getout);
                    listaidade.Add(idade);
                }
                Console.Clear();
            }
            while (getout != "sair");

            double media = listaidade.Average();

            if (media >= 0 && media <= 25)
                Console.WriteLine("A turma inserida é Jovem");

            if (media >= 26 && media <= 60)
                Console.WriteLine("A turma inserida é Adulta");

            if (media > 60)
                Console.WriteLine("A turma inserida é Idosa");

            Console.ReadLine();
        }
    }
}
