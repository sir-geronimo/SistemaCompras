using System;

namespace Sistemacompras.Dto
{
    public class ItemRequestDto
    {
        public int Id { get; set; }
        public string Employee { get; set; }
        public DateTime Date { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
