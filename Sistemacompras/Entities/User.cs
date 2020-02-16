using Sistemacompras.Contracts;
using System;

namespace Sistemacompras.Entities
{
    class User : IAuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identification { get; set; }
        public int? StatusId { get; set; }
        public virtual Status Status { get; set; }

        #region Interface
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        #endregion
    }
}
