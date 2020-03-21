using System.Collections.Generic;

namespace Pericia.Wikidata
{
    public static class StatementsHelper
    {
        public static IEnumerable<Statement>? FindStatements(this Entity entity, string propertyId)
        {
            return entity.Statements.FindStatements(propertyId);
        }

        public static IEnumerable<Statement>? FindStatements(this Dictionary<string, IEnumerable<Statement>> statements, string propertyId)
        {
            if (statements.ContainsKey(propertyId))
            {
                return statements[propertyId];
            }

            return null;
        }
    }
}
