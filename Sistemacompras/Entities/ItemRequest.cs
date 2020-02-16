using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistemacompras.Contracts;

namespace Sistemacompras.Entities
{
    class ItemRequest : IAuditableEntity
    {
        public int Id { get; set; }
        public int RequestedBy { get; set; }
        public virtual Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public int? ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int Quantity { get; set; }
        public int? UnitId { get; set; }
        public virtual Unit Unit { get; set; }
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
