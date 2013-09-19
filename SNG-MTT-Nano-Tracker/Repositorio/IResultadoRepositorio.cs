using SNGMTTNanoTracker.Data;
using System;
using System.Collections.Generic;
namespace SNGMTTNanoTracker.Repositorio
{
    public interface IResultadoRepositorio
    {
        void Novo(Resultados resultado);
        Resultados ObterResultadoPorTorneioId(int id);
        IEnumerable<Resultados> ObterTodos();
        IEnumerable<Resultados> ObterPorDataInicio(DateTime valor);
        Resultados ObterResultadoPorId(int resultadoId);
        void Salvar();
        IEnumerable<Resultados> ObterPorDataInicioEhDataFim(DateTime dataInicio, DateTime dateFim);
    }
}
