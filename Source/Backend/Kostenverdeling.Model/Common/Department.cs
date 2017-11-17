using System.Collections.Generic;

namespace Kostenverdeling.Model.Common
{
    /// <summary>
    /// Defines a business department, a container for the different divisions.
    /// </summary>
    public sealed class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Division> Divisions { get; set; }
        public bool IsUnknown { get; set; }
        public bool CanIgnore { get; set; }

        public override string ToString() {
            return $"{Id} - {Name}";
        }
    }
}
