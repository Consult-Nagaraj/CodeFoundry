using System;
using CodeFoundry.Core.Models;
using System.Collections.Generic;
using System.Text;

namespace CodeFoundry.Core.Builders
{
    public static class ViewSqlBuilderCore
    {
        public static string Build(ViewSqlBuildRequest req)
        {
            if (req == null)
                throw new ArgumentNullException(nameof(req));

            if (req.SelectColumns == null || req.SelectColumns.Count == 0)
                throw new ArgumentException("SelectColumns cannot be empty.", nameof(req));

            if (req.Joins == null)
                req.Joins = new List<JoinSpec>();

            var sb = new StringBuilder();

            sb.AppendLine("CREATE OR REPLACE VIEW " + req.ViewName);
            sb.AppendLine("AS");
            sb.AppendLine("SELECT");

            for (int i = 0; i < req.SelectColumns.Count; i++)
            {
                var col = req.SelectColumns[i];

                sb.Append("    ")
                  .Append(col.Expression)
                  .Append(" AS ")
                  .Append(col.Alias);

                if (i < req.SelectColumns.Count - 1)
                    sb.Append(",");

                sb.AppendLine();
            }

            sb.AppendLine("FROM " + req.TableName + " e");
            sb.AppendLine("LEFT JOIN " + req.TableName + " ed");
            sb.AppendLine("  ON e.Id = ed.Id");
            sb.AppendLine(" AND ed.Status IN ('E','D')");
            sb.AppendLine(" AND ed.ApprStatus = 'P'");

            foreach (var join in req.Joins)
                sb.AppendLine(join.JoinSql);

            sb.AppendLine("WHERE");
            sb.AppendLine("    e.Status = 'A'");
            sb.AppendLine("AND e.ApprStatus = 'A';");

            return sb.ToString();
        }
    }
}
