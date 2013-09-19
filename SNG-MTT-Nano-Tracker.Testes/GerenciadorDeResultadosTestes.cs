using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using SNGMTTNanoTracker.Dominio;
using SNGMTTNanoTracker.Repositorio;
using SNGMTTNanoTracker.Data;

namespace SNGMTTNanoTracker.Testes
{
    [TestFixture]
    public class GerenciadorDeResultadosTestes
    {
        public GerenciadorDeResultadosTestes()
        {
            Configuracoes.Jogador = "dfcastro.net";
        }
        public string ObterDiretorioDeArquivos()
        {
            return Environment.CurrentDirectory + "\\..\\..\\Arquivos\\";
        }

        private Mock<IResultadoRepositorio> _resultadoRepositorio;
        private Mock<IGerenciadorDeArquivos> _gerenciadorDeArquivos;
        
        private GerenciadorDeResultados CriarGerenciadorDeResultados()
        {
            _resultadoRepositorio = new Mock<IResultadoRepositorio>();
            _gerenciadorDeArquivos = new Mock<IGerenciadorDeArquivos>();

            Configuracoes.Path = ObterDiretorioDeArquivos();
            Configuracoes.PathTournSummary = ObterDiretorioDeArquivos() + "\\TournSummary";

            return new GerenciadorDeResultados(_resultadoRepositorio.Object, _gerenciadorDeArquivos.Object);
        }

        [Test]
        public void DeveCarregarResultado()
        {
            var resultado = CriarGerenciadorDeResultados();

            resultado.SalvarResultado(ObterDiretorioDeArquivos() + "HH20130427 T725058424 No Limit Hold'em $0.23 + $0.02.txt");

            _resultadoRepositorio.Verify(metodo => metodo.Novo(It.IsAny<Resultados>()), Times.Once());
        }

        [Test]
        public void PosicaoDeveSerIgualHaDecimoSetimo()
        {
            var resultado = CriarGerenciadorDeResultados();

            resultado.SalvarResultado(ObterDiretorioDeArquivos() + "HH20130619 T749571403 No Limit Hold'em $1.35 + $0.15.txt");

            _resultadoRepositorio.Verify(metodo => metodo.Novo(It.Is<Resultados>(x => x.Posicao == 17)), Times.Once());
        }

        [Test]
        public void PosicaoDeveSerIgualHaSegundo()
        {
            var resultado = CriarGerenciadorDeResultados();

            resultado.SalvarResultado(ObterDiretorioDeArquivos() + "HH20130621 T750518676 No Limit Hold'em $0.23 + $0.02.txt");

            _resultadoRepositorio.Verify(metodo => metodo.Novo(It.Is<Resultados>(x => x.Posicao == 2)), Times.Once());
        }

        [Test]
        public void PremiacaoPagaDeveSerIgualHaDoisDolaresEhVinteDoisCentavos()
        {
            var resultado = CriarGerenciadorDeResultados();

            resultado.SalvarResultado(ObterDiretorioDeArquivos() + "HH20130621 T750518676 No Limit Hold'em $0.23 + $0.02.txt");

            _resultadoRepositorio.Verify(metodo => metodo.Novo(It.Is<Resultados>(x => x.Winning == Convert.ToDecimal("2,22"))), Times.Once());
        }

        [Test]
        public void PremiacaoPagaDeveSerIgualHaTresDolaresEhVinteTresCentavos()
        {
            var resultado = CriarGerenciadorDeResultados();

            resultado.SalvarResultado(ObterDiretorioDeArquivos() + "HH20130427 T725058424 No Limit Hold'em $0.23 + $0.02.txt");

            _resultadoRepositorio.Verify(metodo => metodo.Novo(It.Is<Resultados>(x => x.Winning == Convert.ToDecimal("3,23"))), Times.Once());
        }

        [Test]
        public void TorneioIdDeveSerIgualHa725058424()
        {
            var resultado = CriarGerenciadorDeResultados();

            resultado.SalvarResultado(ObterDiretorioDeArquivos() + "HH20130427 T725058424 No Limit Hold'em $0.23 + $0.02.txt");

            _resultadoRepositorio.Verify(metodo => metodo.Novo(It.Is<Resultados>(x => x.TorneioID == 725058424)), Times.Once());
        }

        [Test]
        public void MesaDeveTerValorValido()
        {
            var resultado = CriarGerenciadorDeResultados();

            resultado.SalvarResultado(ObterDiretorioDeArquivos() + "HH20130427 T725058424 No Limit Hold'em $0.23 + $0.02.txt");

            _resultadoRepositorio.Verify(metodo => metodo.Novo(It.Is<Resultados>(x => x.Mesa == "No Limit Hold'em $0.23 + $0.02")), Times.Once());
        }

        [Test]
        public void BuyInEhRakeDeveSerIgualHaVinteCincoCentavos()
        {
            var resultado = CriarGerenciadorDeResultados();

            resultado.SalvarResultado(ObterDiretorioDeArquivos() + "HH20130427 T725058424 No Limit Hold'em $0.23 + $0.02.txt");

            _resultadoRepositorio.Verify(metodo => metodo.Novo(It.Is<Resultados>(x => x.BuyInRake == Convert.ToDecimal("0,25"))), Times.Once());
        }

        [Test]
        public void DataFimDeveSerValida()
        {
            var resultado = CriarGerenciadorDeResultados();

            resultado.SalvarResultado(ObterDiretorioDeArquivos() + "HH20130427 T725058424 No Limit Hold'em $0.23 + $0.02.txt");

            _resultadoRepositorio.Verify(metodo => metodo.Novo(It.Is<Resultados>(x => x.Fim.ToShortDateString() == "27/04/2013")), Times.Once());
            _resultadoRepositorio.Verify(metodo => metodo.Novo(It.Is<Resultados>(x => x.Fim.ToLongTimeString() == "17:51:54")), Times.Once());
        }

        [Test]
        public void DataInicioDeveSerValida()
        {
            var resultado = CriarGerenciadorDeResultados();

            resultado.SalvarResultado(ObterDiretorioDeArquivos() + "HH20130427 T725058424 No Limit Hold'em $0.23 + $0.02.txt");

            _resultadoRepositorio.Verify(metodo => metodo.Novo(It.Is<Resultados>(x => x.Inicio.ToShortDateString() == "27/04/2013")), Times.Once());
            _resultadoRepositorio.Verify(metodo => metodo.Novo(It.Is<Resultados>(x => x.Inicio.ToLongTimeString() == "15:39:33")), Times.Once());
        }

        [Test]
        public void NaoDeveSalvarResultadosDuplicado()
        {
            var resultado = CriarGerenciadorDeResultados();
            _resultadoRepositorio.Setup(metodo => metodo.ObterResultadoPorTorneioId(It.IsAny<int>())).Returns(new Resultados { });

            resultado.SalvarResultado(ObterDiretorioDeArquivos() + "HH20130427 T725058424 No Limit Hold'em $0.23 + $0.02.txt");

            _resultadoRepositorio.Verify(metodo => metodo.Novo(It.IsAny<Resultados>()), Times.Never());
        }

        [Test]
        public void DeveIgnorarHistoricoDeMesasSemBuyIn()
        {
            var resultado = CriarGerenciadorDeResultados();

            resultado.SalvarResultado(ObterDiretorioDeArquivos() + "HH20130615 T744111947 No Limit Hold'em 5 FPP.txt");

            _resultadoRepositorio.Verify(metodo => metodo.Novo(It.IsAny<Resultados>()), Times.Never());
        }

        [Test]
        public void QuantidadeDeJogadoresDeveSerIgualHa90()
        {
            var resultado = CriarGerenciadorDeResultados();

            resultado.SalvarResultado(ObterDiretorioDeArquivos() + "HH20130629 T754035897 No Limit Hold'em $0.23 + $0.02.txt");

            _resultadoRepositorio.Verify(metodo => metodo.Novo(It.Is<Resultados>(x => x.Jogadores == "90 players")), Times.Once());
        }

        [Test]
        public void DeveCarregarResultadoQuandoUltimaMaoFoiCarregadaHaMaisDeDuasHoras()
        {
            var resultado = CriarGerenciadorDeResultados();

            resultado.SalvarResultado(ObterDiretorioDeArquivos() + "HH20130601 T741051100 No Limit Hold'em $0.91 + $0.09.txt");

            _resultadoRepositorio.Verify(metodo => metodo.Novo(It.IsAny<Resultados>()), Times.Once());
        }

    }
}
