using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistemacompras.Contracts;

namespace Sistemacompras.Entities
{
    class Item : IAuditableEntity
    {
        [Key]
        public int Id { get; set; }
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
