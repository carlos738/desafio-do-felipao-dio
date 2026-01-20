using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NivelDoHeroi
{
    public class NivelDoHeroi
    {
        static void Main(string[] args)
        {
            string nome = "Arthas";
            int xp = 7500;
            string nivel = "";

            if (xp < 1000)
            {
                nivel = "Ferro";
            }else if (xp <= 2000)
            {
                nivel = "Bronze";
            }else if (xp <= 5000)
            {
                nivel = "Prata";
            }else if (xp <= 7000)
            {
                nivel = "Ouro";
            }else if (xp <= 8000)
            {
                nivel = "Platina";
            }else if (xp <= 9000)
            {
                nivel = "Ascendente";
            }else if (xp <= 100000)
            {
                nivel = "Imortal";
            }else{
                nivel = "Radiante";
            }
            Console.WriteLine($"O herói de nome {nome} está no nível de {nivel}");
        }
    }
}