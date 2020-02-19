using Sistemacompras.Contracts;
using System;
using System.ComponentModel.DataAnnotations;

namespace Sistemacompras.Entities
{
    class Item : IAuditableEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public int? BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public int? UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        public int Stock { get; set; }
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
