using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemacompras.Dto
{
    class ItemDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Unit { get; set; }
        public int Stock { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
