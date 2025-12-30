using System.Collections.Generic;

public sealed class ForeignKeyConfigState
{
    public string ReferenceTable { get; set; }
    public string ReferenceKey { get; set; }
    public string ReferenceTableAlias { get; set; }

    // 🔥 NEW: MULTI DISPLAY COLUMNS
    public List<FkDisplayColumn> DisplayColumns { get; set; }
}

public sealed class FkDisplayColumn
{
    public string ColumnName { get; set; }   // Code, Name
    public string Alias { get; set; }        // DepartmentCode, DepartmentName
}
