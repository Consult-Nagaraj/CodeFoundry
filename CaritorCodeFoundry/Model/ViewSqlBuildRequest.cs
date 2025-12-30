using System.Collections.Generic;

namespace CodeFoundry.Core.Models
{
    public sealed class ViewSqlBuildRequest
    {
        public string TableName { get; set; }
        public string ViewName { get; set; }

        public List<SelectColumnSpec> SelectColumns { get; set; }
        public List<JoinSpec> Joins { get; set; }
    }

    public sealed class SelectColumnSpec
    {
        public string Expression { get; set; } // e.g. IFNULL(ed.Id, e.Id)
        public string Alias { get; set; }      // e.g. Id
    }

    public sealed class JoinSpec
    {
        public string JoinSql { get; set; }    // full LEFT JOIN line
    }
}
