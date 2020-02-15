using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistemacompras.Contracts;

namespace Sistemacompras.Entities
{
    class PurchaseOrder : IAuditableEntity
    {
        public int Id { get; set; }
        public int ItemRequestId { get; set; }
        public virtual ItemRequest ItemRequest { get; set; }
        public DateTime Date { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int Quantity { get; set; }
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public double Price { get; set; }

        #region Interface
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
        #endregion
    }
}
