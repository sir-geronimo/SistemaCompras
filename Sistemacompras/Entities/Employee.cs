using Sistemacompras.Contracts;
using System;
using System.ComponentModel.DataAnnotations;

namespace Sistemacompras.Entities
{
    class Employee : IAuditableEntity
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
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
