using SNGMTTNanoTracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SNGMTTNanoTracker.Repositorio
{
    public class ConfiguracaoRepositorio : SNGMTTNanoTracker.Repositorio.IConfiguracaoRepositorio 
    {
        DatabasePokerEntities entities = PokerDatabaseEntitiesFactory.GetEntities();
        public IEnumerable<Configuracao> ObterTodasConfiguracoes()
        {
            return entities.Configuracao;
        }

        public void Salvar()
        {
            entities.SaveChanges();
        }
    }
}
