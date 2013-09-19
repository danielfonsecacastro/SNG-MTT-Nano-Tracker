using SNGMTTNanoTracker.Dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;


namespace SimuladorDeMaos
{
    class Program
    {
        static void Main(string[] args)
        {
            var segundos = 3;
            var maos = new Mesa();
            maos.LerMaoes("torneio.txt");

            var caminhoSimulado = @"C:\Users\Daniel\AppData\Local\PokerStars\HandHistory\dfcastronet\";
            var arquivo = "simulado T740445682 " + DateTime.Now.Ticks + ".txt";

            Console.WriteLine("Pressione uma tecla para inciar."); Console.ReadKey();

            using (var stream = File.Create(caminhoSimulado + arquivo)) { stream.Close(); }
            foreach (var item in maos.Maoes)
            {
                Console.WriteLine(item.Conteudo);

                using (var stream = File.Open(caminhoSimulado + arquivo, FileMode.Append))
                {
                    var bytes = Encoding.Default.GetBytes(item.Conteudo + "\r\n\r\n\r\n\r\n");
                    stream.Write(bytes, 0, bytes.Count());

                    stream.Flush();
                    stream.Close();
                }
                Thread.Sleep(segundos * 1000);
                Console.ReadKey();
            }

            Console.WriteLine("Fim {0} mãoes lidas , pressione uma tecla para finalizar.",maos.Maoes.Count); Console.ReadKey();
        }
    }
}
