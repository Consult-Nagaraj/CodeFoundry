using System.Collections.Generic;
using CodeFoundry.Core.Enums;

namespace CodeFoundry.Core.Models
{
    public sealed class ConfigureFieldsState
    {
        // =========================
        // Context
        // =========================
        public string TableName { get; set; }   // Employee
        public string ViewName { get; set; }    // EmployeeVw
        public GridType GridType { get; set; }  // InfoGrid / Normal / Approval / Dropdown

        // =========================
        // User-selected fields
        // ORDER MATTERS
        // =========================
        public IList<FieldConfigState> Fields { get; set; }
    }
}
