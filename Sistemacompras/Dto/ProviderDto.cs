using System;

namespace Sistemacompras.Dto
{
    class ProviderDto
    {
        public int Id { get; set; }
        public string Identification { get; set; }
        public string Name { get; set; }
        public string PublicName { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
