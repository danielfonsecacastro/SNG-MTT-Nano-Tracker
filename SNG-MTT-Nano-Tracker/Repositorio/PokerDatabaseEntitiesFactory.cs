using SNGMTTNanoTracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SNGMTTNanoTracker.Repositorio
{
    public class PokerDatabaseEntitiesFactory
    {
        private static DatabasePokerEntities entities;

        public static DatabasePokerEntities GetEntities()
        {
            if (entities == null)
                entities = new DatabasePokerEntities();

            return entities;
        }
    }
}
