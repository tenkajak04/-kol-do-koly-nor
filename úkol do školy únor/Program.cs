using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace úkol_do_školy_únor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
               // to je aktuální čas
                DateTime cas = DateTime.Now; 
                // první proměnná 
                int cisloMesice = cas.Month;
                //tady vytvoříme pole, kde je všech 12 měsíců 
                string[] pole = { "Leden", "Únor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Zaří", "Říjen", "Listopad", "Prosinec" };
                //tady to vypíše aktuální měsíc- další měsíc - minulý měsíc
                Console.WriteLine($"Teď je:{pole[cisloMesice - 1]}, další měsíc: {pole[cisloMesice]}, předchozí měsíc: {pole[cisloMesice - 2]}");
                Console.Write("Zadejte číslo měsíce (1-12): ");
                // tady jsme si vytvořili další proměnnou a konvertoavali jseme to 
                int mesic = Convert.ToInt32(Console.ReadLine());
                int mesicTeď = mesic - 1;
                int mesicPředchozí = mesic - 2;

                //tenhle cyklus funguje jen od 2 do 11 pro leden a prosinec se to musí speciálně upravit
                if (mesic >= 2 && mesic <= 11)
                {
                    Console.WriteLine($"Teď je:{pole[mesicTeď]}, další měsíc: {pole[mesic]}, předchozí měsíc: {pole[mesicPředchozí]}");

                }
                //// tady to musíme speciálně upravit aby to fungovalo 
                else if (mesic == 1)
                {
                    Console.WriteLine($"Teď je:{pole[0]}, další měsíc: {pole[1]}, předchozí měsíc: {pole[11]}");
                }
                // tady taky jinak by to dalo že další měsíc je [12] což by byl vlastně 13. měsíc, který my nemáme 
                else if (mesic == 12)
                {
                    Console.WriteLine($"Teď je:{pole[11]}, další měsíc: {pole[0]}, předchozí měsíc: {pole[10]}");
                }
                // tady se zeptá jestli chceme vypsat měsíce vybereme buď ano nebo ne
                Console.WriteLine("Chcete vypsat všechny měsíce, y/n  ?");
                string možnost = Console.ReadLine();
                if (možnost == "y")
                {
                    foreach (string ano in pole)
                    {
                        Console.WriteLine(ano);
                    }
                }
                //když dáme ano program všechny vypíše 
                else if (možnost == "n")
                {
                    Console.WriteLine("Tak cs");
                }
                //když dáme že ne program se ukončí 
                
                Console.ReadKey();
                // aby se mi načetli ty měsíce tak jsem musim dát Console.Readkey







            }
        }
    }
}
