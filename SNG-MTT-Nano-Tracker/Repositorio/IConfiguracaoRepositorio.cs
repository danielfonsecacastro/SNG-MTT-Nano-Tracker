using SNGMTTNanoTracker.Data;
using System;
namespace SNGMTTNanoTracker.Repositorio
{
    public interface IConfiguracaoRepositorio
    {
        System.Collections.Generic.IEnumerable<Configuracao> ObterTodasConfiguracoes();
        void Salvar();
    }
}
