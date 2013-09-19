using SNGMTTNanoTracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SNGMTTNanoTracker.Repositorio
{
    public class ResultadoRepositorio : SNGMTTNanoTracker.Repositorio.IResultadoRepositorio
    {
        DatabasePokerEntities entities = PokerDatabaseEntitiesFactory.GetEntities();
        public void Novo(Resultados resultado)
        {
            entities.Resultados.Add(resultado);
            entities.SaveChanges();
        }

        public Resultados ObterResultadoPorTorneioId(int id)
        {
            return entities.Resultados.FirstOrDefault(x => x.TorneioID == id);
        }

        public IEnumerable<Resultados> ObterTodos()
        {
            return entities.Resultados;
        }

        public IEnumerable<Resultados> ObterPorDataInicio(DateTime valor)
        {
            return entities.Resultados.Where(x => x.Inicio >= valor.Date);
        }

        public IEnumerable<string> ObterTodasQuantidadesDeJogadoresCadastrados()
        {
            return entities.Resultados.Select(x => x.Jogadores).Distinct();
        }

        public Resultados ObterResultadoPorId(int resultadoId)
        {
            return entities.Resultados.FirstOrDefault(x => x.ResultadoID == resultadoId);
        }

        public void Salvar()
        {
            entities.SaveChanges();
        }

        public IEnumerable<Resultados> ObterPorDataInicioEhDataFim(DateTime dataInicio, DateTime dateFim)
        {
            var fim = new DateTime(dateFim.Year, dateFim.Month, dateFim.Day, 23, 59, 59);
            return entities.Resultados.Where(x => x.Inicio >= dataInicio.Date && x.Fim <= fim);
        }

        public IEnumerable<string> ObterTodasTablesCadastrada()
        {
            return entities.Resultados.Select(x => x.Mesa).Distinct();
        }
    }
}
