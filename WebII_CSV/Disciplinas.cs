using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebII_CSV
{
    public class Disciplinas
    {
        /*public string nome { get; set; }
        public string periodo { get; set; }
        public string categoria { get; set; }
        public string dificuldade { get; set; }
        public string creditos { get; set; }
        public string horaAula { get; set; }
        public string horaRelogio { get; set; }
        public string qtdTeorica { get; set; }
        public string qtdPratica { get; set; }
        public string ementa { get; set; }

        public static List<Disciplinas> ReadCSV(string filePath)
        {
            List<Disciplinas> disciplinas = new();

            StreamReader sr = new StreamReader(filePath);
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine()!;
                string[] detailsLine = line.Split(';');
            }
            return disciplinas;
        }*/

        /*var list = File.ReadAllLines(openFileDialog.FileName)
                    .Select(a => a.Split(';'))
                    .Select(c => new Disciplinas()
                    {
                        nome = c[0],
                        periodo = c[1],
                        categoria = c[2],
                        dificuldade = c[3],
                        creditos = c[4],
                        horaAula = c[5],
                        horaRelogio = c[6],
                        qtdPratica = c[7],
                        qtdTeorica = c[8],
                        ementa = c[9]
                    }).ToList();*/
    }
}
