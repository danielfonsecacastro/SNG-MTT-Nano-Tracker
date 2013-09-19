using NUnit.Framework;
using SNGMTTNanoTracker.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SNGMTTNanoTracker.Testes
{
    [TestFixture]
    public class MesaTestes
    {
        public string ObterDiretorioDeArquivos()
        {
            return Environment.CurrentDirectory + "\\..\\..\\Arquivos\\";
        }

        [Test]
        public void DeveRetornarTresMaoes()
        {
            var mesa = new Mesa();

            mesa.LerMaoes(ObterDiretorioDeArquivos() + "Arquivo3Maos.txt");
            var resultado = mesa.Maoes;

            Assert.AreEqual(3, resultado.Count());
        }

        [Test]
        public void ConteudoDaMaoUmDeveSerValida()
        {
            var mesa = new Mesa();

            mesa.LerMaoes(ObterDiretorioDeArquivos() + "Arquivo3Maos.txt");
            var resultado = mesa.Maoes;

            Assert.AreEqual(@"PokerStars Hand #96878398484: Tournament #716429497, $0.45+$0.05 USD Hold'em No Limit - Level I (10/20) - 2013/04/08 19:12:42 BRT [2013/04/08 18:12:42 ET]
Table '716429497 2' 9-max Seat #1 is the button
Seat 1: Husky582002 (1500 in chips) 
Seat 2: Sziklavari01 (1500 in chips) 
Seat 3: dfcastro.net (1500 in chips) 
Seat 4: perak 1955 (1500 in chips) 
Seat 5: skandal76 (1500 in chips) 
Seat 6: DanteDelgado (1500 in chips) 
Seat 7: Rožica340 (1500 in chips) 
Seat 8: tuche48 (1500 in chips) 
Seat 9: oHitTheRiver (1500 in chips) 
Sziklavari01: posts small blind 10
dfcastro.net: posts big blind 20
*** HOLE CARDS ***
Dealt to dfcastro.net [Kd 7c]
perak 1955: folds 
skandal76: folds 
DanteDelgado: folds 
Rožica340: folds 
tuche48 has timed out while being disconnected
tuche48: folds 
tuche48 is sitting out
oHitTheRiver: folds 
tuche48 is disconnected 
Husky582002: folds 
Sziklavari01: folds 
Uncalled bet (10) returned to dfcastro.net
dfcastro.net collected 20 from pot
*** SUMMARY ***
Total pot 20 | Rake 0 
Seat 1: Husky582002 (button) folded before Flop (didn't bet)
Seat 2: Sziklavari01 (small blind) folded before Flop
Seat 3: dfcastro.net (big blind) collected (20)
Seat 4: perak 1955 folded before Flop (didn't bet)
Seat 5: skandal76 folded before Flop (didn't bet)
Seat 6: DanteDelgado folded before Flop (didn't bet)
Seat 7: Rožica340 folded before Flop (didn't bet)
Seat 8: tuche48 folded before Flop (didn't bet)
Seat 9: oHitTheRiver folded before Flop (didn't bet)", resultado.First().Conteudo);
        }
    }
}
