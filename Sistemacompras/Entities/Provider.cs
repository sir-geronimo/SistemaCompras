using Sistemacompras.Contracts;
using System;
using System.ComponentModel.DataAnnotations;

namespace Sistemacompras.Entities
{
    class Provider : IAuditableEntity
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Identification { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string PublicName { get; set; }
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
