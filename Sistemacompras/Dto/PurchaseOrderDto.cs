using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemacompras.Dto
{
    class PurchaseOrderDto
    {
        public int Id { get; set; }
        public int ItemRequest { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
