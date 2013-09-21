using NUnit.Framework;
using SNGMTTNanoTracker.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SNGMTTNanoTracker.Testes
{
    [TestFixture]
    public class MaoTestes
    {
        public MaoTestes()
        {
            Configuracoes.Jogador = "dfcastro.net";
        }

        public string TextoConteudo()
        {
            return @"PokerStars Hand #96878398484: Tournament #716429497, $0.45+$0.05 USD Hold'em No Limit - Level I (10/20) - 2013/04/08 19:12:42 BRT [2013/04/08 18:12:42 ET]
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
Seat 9: oHitTheRiver folded before Flop (didn't bet)";
        }

        [Test]
        public void DeveCarregarDataCorretamente()
        {
            var mao = new Mao(TextoConteudo());

            Assert.AreEqual("2013/04/08 19:12:42", mao.Data.ToString("yyyy/MM/dd HH:mm:ss"));
        }

        [Test]
        public void DeveCarregarDataCorretamenteMesmoQuandoFormatoForInvalido()
        {
            var mao = new Mao(@"PokerStars Hand #104413064757: Tournament #791245034, $0.09+$0.01 USD Hold'em No Limit - Level I (10/20) - 2013/09/20 21:36:15 ET
Table '791245034 2' 9-max Seat #1 is the button
Seat 1: dfcastro.net (1500 in chips) 
Seat 2: soniasandrin (1500 in chips) 
Seat 3: josecatan (1500 in chips) 
Seat 4: todoherraje (1500 in chips) 
Seat 5: kids5542 (1500 in chips) 
Seat 6: visprenski (1500 in chips) 
Seat 7: manganão13 (1500 in chips) 
Seat 8: todeolho (1500 in chips) 
Seat 9: rependejo (1500 in chips) 
soniasandrin: posts small blind 10
josecatan: posts big blind 20
*** HOLE CARDS ***
Dealt to dfcastro.net [2c Kd]
todoherraje: calls 20
kids5542: calls 20
visprenski: folds 
manganão13: folds 
todeolho: calls 20
rependejo: raises 20 to 40
dfcastro.net: folds 
soniasandrin: calls 30
josecatan: calls 20
todoherraje: calls 20
kids5542: calls 20
todeolho: calls 20
*** FLOP *** [Jc Jh 3s]
soniasandrin: checks 
josecatan: checks 
todoherraje: checks 
kids5542: checks 
todeolho: checks 
rependejo: bets 140
soniasandrin: folds 
josecatan: folds 
todoherraje has timed out
todoherraje: folds 
todoherraje is sitting out
todoherraje has returned
kids5542: folds 
todeolho: folds 
Uncalled bet (140) returned to rependejo
todeolho is sitting out
rependejo collected 240 from pot
*** SUMMARY ***
Total pot 240 | Rake 0 
Board [Jc Jh 3s]
Seat 1: dfcastro.net (button) folded before Flop (didn't bet)
Seat 2: soniasandrin (small blind) folded on the Flop
Seat 3: josecatan (big blind) folded on the Flop
Seat 4: todoherraje folded on the Flop
Seat 5: kids5542 folded on the Flop
Seat 6: visprenski folded before Flop (didn't bet)
Seat 7: manganão13 folded before Flop (didn't bet)
Seat 8: todeolho folded on the Flop
Seat 9: rependejo collected (240)");

            Assert.AreEqual(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), mao.Data.ToString("dd/MM/yyyy hh:mm:ss"));
        }

        [Test]
        public void HandIdDeveSerValido()
        {
            var mao = new Mao(@"PokerStars Hand #98217190126: Tournament #729294977, $0.23+$0.02 USD Hold'em No Limit - Level XIII (600/1200) - 2013/05/06 23:34:01 BRT [2013/05/06 22:34:01 ET]
Table '729294977 3' 9-max Seat #1 is the button
Seat 1: Kel Playa (963 in chips) 
Seat 4: aston veyron (12203 in chips) 
Seat 7: rahlass (29623 in chips) 
Seat 8: dfcastro.net (24711 in chips) 
Kel Playa: posts the ante 75
aston veyron: posts the ante 75
rahlass: posts the ante 75
dfcastro.net: posts the ante 75
aston veyron: posts small blind 600
rahlass: posts big blind 1200
*** HOLE CARDS ***
Dealt to dfcastro.net [Th Ts]
dfcastro.net: raises 1200 to 2400
Kel Playa: calls 888 and is all-in
aston veyron: folds 
rahlass: folds 
Uncalled bet (1200) returned to dfcastro.net
*** FLOP *** [Kh 8h Qc]
*** TURN *** [Kh 8h Qc] [2h]
*** RIVER *** [Kh 8h Qc 2h] [6h]
*** SHOW DOWN ***
dfcastro.net: shows [Th Ts] (a flush, King high)
dfcastro.net collected 624 from side pot
Kel Playa: shows [8c As] (a pair of Eights)
dfcastro.net collected 3564 from main pot
Kel Playa finished the tournament in 4th place and received $1.29.
*** SUMMARY ***
Total pot 4188 Main pot 3564. Side pot 624. | Rake 0 
Board [Kh 8h Qc 2h 6h]
Seat 1: Kel Playa (button) showed [8c As] and lost with a pair of Eights
Seat 4: aston veyron (small blind) folded before Flop
Seat 7: rahlass (big blind) folded before Flop
Seat 8: dfcastro.net showed [Th Ts] and won (4188) with a flush, King high");

            Assert.AreEqual("98217190126", mao.HandId);
        }

        [Test]
        public void TemShowDownDeveRetornarTrue()
        {
            var mao = new Mao(@"PokerStars Hand #98217190126: Tournament #729294977, $0.23+$0.02 USD Hold'em No Limit - Level XIII (600/1200) - 2013/05/06 23:34:01 BRT [2013/05/06 22:34:01 ET]
Table '729294977 3' 9-max Seat #1 is the button
Seat 1: Kel Playa (963 in chips) 
Seat 4: aston veyron (12203 in chips) 
Seat 7: rahlass (29623 in chips) 
Seat 8: dfcastro.net (24711 in chips) 
Kel Playa: posts the ante 75
aston veyron: posts the ante 75
rahlass: posts the ante 75
dfcastro.net: posts the ante 75
aston veyron: posts small blind 600
rahlass: posts big blind 1200
*** HOLE CARDS ***
Dealt to dfcastro.net [Th Ts]
dfcastro.net: raises 1200 to 2400
Kel Playa: calls 888 and is all-in
aston veyron: folds 
rahlass: folds 
Uncalled bet (1200) returned to dfcastro.net
*** FLOP *** [Kh 8h Qc]
*** TURN *** [Kh 8h Qc] [2h]
*** RIVER *** [Kh 8h Qc 2h] [6h]
*** SHOW DOWN ***
dfcastro.net: shows [Th Ts] (a flush, King high)
dfcastro.net collected 624 from side pot
Kel Playa: shows [8c As] (a pair of Eights)
dfcastro.net collected 3564 from main pot
Kel Playa finished the tournament in 4th place and received $1.29.
*** SUMMARY ***
Total pot 4188 Main pot 3564. Side pot 624. | Rake 0 
Board [Kh 8h Qc 2h 6h]
Seat 1: Kel Playa (button) showed [8c As] and lost with a pair of Eights
Seat 4: aston veyron (small blind) folded before Flop
Seat 7: rahlass (big blind) folded before Flop
Seat 8: dfcastro.net showed [Th Ts] and won (4188) with a flush, King high");

            Assert.IsTrue(mao.TemShowDown);
        }

        [Test]
        public void TemShowDownDeveRetornarFalseParaFoldPreFlop()
        {
            var mao = new Mao(@"PokerStars Hand #103783605853: Tournament #784845367, $0.09+$0.01 USD Hold'em No Limit - Level I (10/20) - 2013/09/07 9:45:12 BRT [2013/09/07 8:45:12 ET]
Table '784845367 3' 9-max Seat #4 is the button
Seat 1: antonio.i (1500 in chips) 
Seat 2: makalelemak (1500 in chips) is sitting out
Seat 3: Edward ENG (1270 in chips) 
Seat 4: dfcastro.net (1470 in chips) 
Seat 5: Murphy11112 (5360 in chips) out of hand (moved from another table into small blind)
Seat 6: myalbaner (1500 in chips) out of hand (moved from another table into small blind)
Seat 7: asarafov (1500 in chips) 
Seat 8: Mr.MD333 (1500 in chips) 
Seat 9: TigerTAV (9340 in chips) 
asarafov: posts small blind 10
Mr.MD333: posts big blind 20
*** HOLE CARDS ***
Dealt to dfcastro.net [Ah 5h]
TigerTAV: calls 20
antonio.i has timed out
antonio.i: folds 
makalelemak: folds 
antonio.i is sitting out
Edward ENG: raises 1250 to 1270 and is all-in
dfcastro.net: folds 
asarafov: folds 
Mr.MD333: folds 
TigerTAV: calls 1250
*** FLOP *** [8d Ad 5d]
*** TURN *** [8d Ad 5d] [Qh]
*** RIVER *** [8d Ad 5d Qh] [4s]
*** SHOW DOWN ***
TigerTAV: shows [Kd 9s] (high card Ace)
Edward ENG: shows [4d 7c] (a pair of Fours)
Edward ENG collected 2570 from pot
*** SUMMARY ***
Total pot 2570 | Rake 0 
Board [8d Ad 5d Qh 4s]
Seat 1: antonio.i folded before Flop (didn't bet)
Seat 2: makalelemak folded before Flop (didn't bet)
Seat 3: Edward ENG showed [4d 7c] and won (2570) with a pair of Fours
Seat 4: dfcastro.net (button) folded before Flop (didn't bet)
Seat 7: asarafov (small blind) folded before Flop
Seat 8: Mr.MD333 (big blind) folded before Flop
Seat 9: TigerTAV showed [Kd 9s] and lost with high card Ace");

            Assert.IsFalse(mao.TemShowDown);
        }

        [Test]
        public void TeveAcaoDeveRetornarFalseParaFoldPreFlop()
        {
            var mao = new Mao(@"PokerStars Hand #103784306982: Tournament #784847335, $0.09+$0.01 USD Hold'em No Limit - Level V (30/60) - 2013/09/07 10:07:27 BRT [2013/09/07 9:07:27 ET]
Table '784847335 1' 9-max Seat #4 is the button
Seat 1: samlik36484 (2545 in chips) 
Seat 2: Scalar01 (2470 in chips) 
Seat 3: Borets80 (3520 in chips) 
Seat 4: darko315 (2930 in chips) 
Seat 5: picnic801 (1910 in chips) 
Seat 6: VKravtsevich (1580 in chips) 
Seat 7: Marisaisabel (1550 in chips) 
Seat 8: dfcastro.net (1440 in chips) 
Seat 9: milawka85 (1310 in chips) 
picnic801: posts small blind 30
VKravtsevich: posts big blind 60
*** HOLE CARDS ***
Dealt to dfcastro.net [Qh 5c]
Marisaisabel: folds 
dfcastro.net: folds 
milawka85: folds 
samlik36484: folds 
Scalar01: calls 60
Borets80: folds 
darko315: folds 
picnic801: folds 
VKravtsevich: checks 
*** FLOP *** [2s 7h Ks]
VKravtsevich: checks 
Scalar01: checks 
*** TURN *** [2s 7h Ks] [3c]
VKravtsevich: checks 
Scalar01: checks 
*** RIVER *** [2s 7h Ks 3c] [4h]
VKravtsevich: bets 60
Scalar01: folds 
Uncalled bet (60) returned to VKravtsevich
VKravtsevich collected 150 from pot
*** SUMMARY ***
Total pot 150 | Rake 0 
Board [2s 7h Ks 3c 4h]
Seat 1: samlik36484 folded before Flop (didn't bet)
Seat 2: Scalar01 folded on the River
Seat 3: Borets80 folded before Flop (didn't bet)
Seat 4: darko315 (button) folded before Flop (didn't bet)
Seat 5: picnic801 (small blind) folded before Flop
Seat 6: VKravtsevich (big blind) collected (150)
Seat 7: Marisaisabel folded before Flop (didn't bet)
Seat 8: dfcastro.net folded before Flop (didn't bet)
Seat 9: milawka85 folded before Flop (didn't bet)");

            Assert.IsFalse(mao.TeveAcao);
        }



        [Test]
        public void TemShowDownDeveRetornarFalse()
        {
            var mao = new Mao(@"PokerStars Hand #100752179959: Tournament #754131974, $0.23+$0.02 USD Hold'em No Limit - Level III (25/50) - 2013/06/29 20:27:08 BRT [2013/06/29 19:27:08 ET]
Table '754131974 2' 9-max Seat #7 is the button
Seat 1: souky710 (1467 in chips) 
Seat 3: dfcastro.net (5950 in chips) 
Seat 4: P_losiek (6815 in chips) 
Seat 6: muse134 (4445 in chips) 
Seat 7: Rckoff86 (4520 in chips) 
Seat 8: Superminge (2959 in chips) 
Seat 9: slidings (2750 in chips) 
Superminge: posts small blind 25
slidings: posts big blind 50
*** HOLE CARDS ***
Dealt to dfcastro.net [3s 2d]
souky710: calls 50
dfcastro.net: folds 
P_losiek has timed out
P_losiek: folds 
P_losiek is sitting out
P_losiek has returned
muse134: folds 
Rckoff86: calls 50
Superminge: calls 25
slidings: checks 
*** FLOP *** [7h 2h 8h]
Superminge: checks 
slidings: checks 
souky710: checks 
Rckoff86: checks 
*** TURN *** [7h 2h 8h] [Ac]
Superminge: checks 
slidings: checks 
souky710: checks 
Rckoff86: checks 
*** RIVER *** [7h 2h 8h Ac] [8s]
Superminge: checks 
slidings: checks 
souky710: checks 
Rckoff86: checks 
*** SHOW DOWN ***
Superminge: shows [4c Tc] (a pair of Eights)
slidings: shows [Qc Th] (a pair of Eights - Ace+Queen kicker)
souky710: shows [6d Ks] (a pair of Eights - Ace+King kicker)
Rckoff86: mucks hand 
souky710 collected 200 from pot
*** SUMMARY ***
Total pot 200 | Rake 0 
Board [7h 2h 8h Ac 8s]
Seat 1: souky710 showed [6d Ks] and won (200) with a pair of Eights
Seat 3: dfcastro.net folded before Flop (didn't bet)
Seat 4: P_losiek folded before Flop (didn't bet)
Seat 6: muse134 folded before Flop (didn't bet)
Seat 7: Rckoff86 (button) mucked [4s 6s]
Seat 8: Superminge (small blind) showed [4c Tc] and lost with a pair of Eights
Seat 9: slidings (big blind) showed [Qc Th] and lost with a pair of Eights");

            Assert.IsFalse(mao.TemShowDown);
        }

        [Test]
        public void TemShowDownDeveRetornarFalseQuandoTodosFoldNoTurn()
        {
            var mao = new Mao(@" PokerStars Hand #100792683181: Tournament #754523189, 9+0 Hold'em No Limit - Level V (40/80) - 2013/06/30 17:19:54 BRT [2013/06/30 16:19:54 ET]
Table '754523189 1' 6-max Seat #1 is the button
Seat 1: zagiZ (3315 in chips) 
Seat 2: frozenus20 (1435 in chips) 
Seat 3: Luiz e Maria (1170 in chips) 
Seat 4: dfcastro.net (1325 in chips) 
Seat 5: jorgebatis53 (1755 in chips) 
zagiZ: posts the ante 5
frozenus20: posts the ante 5
Luiz e Maria: posts the ante 5
dfcastro.net: posts the ante 5
jorgebatis53: posts the ante 5
frozenus20: posts small blind 40
Luiz e Maria: posts big blind 80
*** HOLE CARDS ***
Dealt to dfcastro.net [Qd 4d]
dfcastro.net: calls 80
jorgebatis53: folds 
zagiZ: calls 80
frozenus20: calls 40
Luiz e Maria: checks 
*** FLOP *** [7c 4s Ad]
frozenus20: checks 
Luiz e Maria: checks 
dfcastro.net: checks 
zagiZ: checks 
*** TURN *** [7c 4s Ad] [4c]
frozenus20: checks 
Luiz e Maria: checks 
dfcastro.net: bets 320
zagiZ: folds 
frozenus20: folds 
Luiz e Maria: folds 
Uncalled bet (320) returned to dfcastro.net
dfcastro.net collected 345 from pot
dfcastro.net: doesn't show hand 
*** SUMMARY ***
Total pot 345 | Rake 0 
Board [7c 4s Ad 4c]
Seat 1: zagiZ (button) folded on the Turn
Seat 2: frozenus20 (small blind) folded on the Turn
Seat 3: Luiz e Maria (big blind) folded on the Turn
Seat 4: dfcastro.net collected (345)
Seat 5: jorgebatis53 folded before Flop (didn't bet)");

            Assert.IsFalse(mao.TemShowDown);
        }

        [Test]
        public void TeveAcaoDeveRetornarTrue()
        {
            var mao = new Mao(@"PokerStars Hand #98217190126: Tournament #729294977, $0.23+$0.02 USD Hold'em No Limit - Level XIII (600/1200) - 2013/05/06 23:34:01 BRT [2013/05/06 22:34:01 ET]
Table '729294977 3' 9-max Seat #1 is the button
Seat 1: Kel Playa (963 in chips) 
Seat 4: aston veyron (12203 in chips) 
Seat 7: rahlass (29623 in chips) 
Seat 8: dfcastro.net (24711 in chips) 
Kel Playa: posts the ante 75
aston veyron: posts the ante 75
rahlass: posts the ante 75
dfcastro.net: posts the ante 75
aston veyron: posts small blind 600
rahlass: posts big blind 1200
*** HOLE CARDS ***
Dealt to dfcastro.net [Th Ts]
dfcastro.net: raises 1200 to 2400
Kel Playa: calls 888 and is all-in
aston veyron: folds 
rahlass: folds 
Uncalled bet (1200) returned to dfcastro.net
*** FLOP *** [Kh 8h Qc]
*** TURN *** [Kh 8h Qc] [2h]
*** RIVER *** [Kh 8h Qc 2h] [6h]
*** SHOW DOWN ***
dfcastro.net: shows [Th Ts] (a flush, King high)
dfcastro.net collected 624 from side pot
Kel Playa: shows [8c As] (a pair of Eights)
dfcastro.net collected 3564 from main pot
Kel Playa finished the tournament in 4th place and received $1.29.
*** SUMMARY ***
Total pot 4188 Main pot 3564. Side pot 624. | Rake 0 
Board [Kh 8h Qc 2h 6h]
Seat 1: Kel Playa (button) showed [8c As] and lost with a pair of Eights
Seat 4: aston veyron (small blind) folded before Flop
Seat 7: rahlass (big blind) folded before Flop
Seat 8: dfcastro.net showed [Th Ts] and won (4188) with a flush, King high");

            Assert.IsTrue(mao.TeveAcao);
        }

        [Test]
        public void TeveAcaoDeveRetornarFalse()
        {
            var mao = new Mao(@"PokerStars Hand #100938743001: Tournament #755977914, $0.23+$0.02 USD Hold'em No Limit - Level IV (50/100) - 2013/07/03 22:01:24 BRT [2013/07/03 21:01:24 ET]
Table '755977914 2' 9-max Seat #1 is the button
Seat 1: venisonboats (2410 in chips) 
Seat 3: bobmario14 (1684 in chips) 
Seat 4: ricky128815 (975 in chips) 
Seat 5: dfcastro.net (2355 in chips) 
Seat 6: lapino842 (3746 in chips) 
Seat 8: ReEwel (2680 in chips) 
Seat 9: KateCole09 (1590 in chips) 
bobmario14: posts small blind 50
ricky128815: posts big blind 100
*** HOLE CARDS ***
Dealt to dfcastro.net [Th 2c]
dfcastro.net: folds 
lapino842 has timed out
lapino842: folds 
lapino842 is sitting out
ReEwel: calls 100
KateCole09: folds 
venisonboats: folds 
bobmario14: calls 50
ricky128815: checks 
*** FLOP *** [6c Qh 5s]
bobmario14: checks 
ricky128815: checks 
lapino842 has returned
ReEwel: bets 100
bobmario14: folds 
ricky128815: raises 775 to 875 and is all-in
ReEwel: calls 775
*** TURN *** [6c Qh 5s] [3d]
*** RIVER *** [6c Qh 5s 3d] [2s]
*** SHOW DOWN ***
ricky128815: shows [4s Qs] (a straight, Deuce to Six)
ReEwel: shows [5h 5d] (three of a kind, Fives)
ricky128815 collected 2050 from pot
*** SUMMARY ***
Total pot 2050 | Rake 0 
Board [6c Qh 5s 3d 2s]
Seat 1: venisonboats (button) folded before Flop (didn't bet)
Seat 3: bobmario14 (small blind) folded on the Flop
Seat 4: ricky128815 (big blind) showed [4s Qs] and won (2050) with a straight, Deuce to Six
Seat 5: dfcastro.net folded before Flop (didn't bet)
Seat 6: lapino842 folded before Flop (didn't bet)
Seat 8: ReEwel showed [5h 5d] and lost with three of a kind, Fives
Seat 9: KateCole09 folded before Flop (didn't bet)");

            Assert.IsFalse(mao.TeveAcao);
        }

        [Test]
        public void TeveAcaoDeveRetornarFalseQuandoTodosFolds()
        {
            var mao = new Mao(@"PokerStars Hand #100939292536: Tournament #755976072, $0.23+$0.02 USD Hold'em No Limit - Level VI (100/200) - 2013/07/03 22:22:30 BRT [2013/07/03 21:22:30 ET]
Table '755976072 4' 9-max Seat #5 is the button
Seat 1: mmiguel5 (2786 in chips) 
Seat 5: dfcastro.net (1827 in chips) 
Seat 6: manomano102 (310 in chips) is sitting out
Seat 7: marciorc78 (7328 in chips) 
Seat 8: chertas3 (5875 in chips) 
Seat 9: vinicets (11562 in chips) 
manomano102: posts small blind 100
marciorc78: posts big blind 200
*** HOLE CARDS ***
Dealt to dfcastro.net [Jh 4c]
chertas3: folds 
vinicets: folds 
mmiguel5: folds 
dfcastro.net: folds 
manomano102: folds 
Uncalled bet (100) returned to marciorc78
marciorc78 collected 200 from pot
marciorc78: doesn't show hand 
*** SUMMARY ***
Total pot 200 | Rake 0 
Seat 1: mmiguel5 folded before Flop (didn't bet)
Seat 5: dfcastro.net (button) folded before Flop (didn't bet)
Seat 6: manomano102 (small blind) folded before Flop
Seat 7: marciorc78 (big blind) collected (200)
Seat 8: chertas3 folded before Flop (didn't bet)
Seat 9: vinicets folded before Flop (didn't bet)");

            Assert.IsFalse(mao.TeveAcao);
        }
    }
}



