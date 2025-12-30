namespace CodeFoundry.Core.Models
{
    public sealed class FieldConfigState
    {
        // =========================
        // Identity
        // =========================
        public string FieldName { get; set; }
        public string DisplayName { get; set; }

        // =========================
        // Grid/UI behavior
        // =========================
        public bool IsVisible { get; set; }
        public int DisplayOrder { get; set; }

        // =========================
        // Data characteristics
        // =========================
        public bool IsNullable { get; set; }
        public int? MaxLength { get; set; }
        public string DataType { get; set; }

        // =========================
        // Validation / Edit behavior
        // =========================
        public bool IsRequired { get; set; }
        public string ValidationPattern { get; set; }
        public string ValidationMessage { get; set; }

        // =========================
        // Foreign Key (optional)
        // =========================
        public ForeignKeyConfigState ForeignKey { get; set; }
    }
}
