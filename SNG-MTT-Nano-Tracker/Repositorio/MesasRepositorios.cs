using SNGMTTNanoTracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SNGMTTNanoTracker.Repositorio
{
    public class MesasRepositorios
    {
        DatabasePokerEntities entities = PokerDatabaseEntitiesFactory.GetEntities();
        public IEnumerable<Mesas> ObterTodas()
        {
            return entities.Mesas;
        }

        public void Inserir(Mesas mesas)
        {
            entities.Mesas.Add(mesas);
            entities.SaveChanges();
        }

        public IEnumerable<Mesas> ObterPorTable(string mesa)
        {
            return entities.Mesas.Where(x => x.Table == mesa);
        }

        public void Excluir(int mesaId)
        {
            entities.Mesas.Remove(entities.Mesas.FirstOrDefault(x => x.MesaID == mesaId));
            entities.SaveChanges();
        }
    }
}
