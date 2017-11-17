using System;
using System.Linq;
using System.Collections.Generic;

namespace Kostenverdeling.Model.Common
{
    /// <summary>
    /// A division of a particular department.
    /// </summary>
    public sealed class Division
    {
        public Division() {
            Ids = new List<int>();
        }

        public Department Department { get; set; }
        public List<int> Ids { get; set; }
        public string Name { get; set; }
        public bool IsUnknown { get; set; }
        public bool CanIgnore { get; set; }
        public int Id => Int32.Parse(String.Join("", Ids.ToArray()));

        public List<AccountingDescription> AccountingDescriptions { get; set; }

        public override string ToString() {
            return $"{Id} - {Name}";
        }
    }
}
