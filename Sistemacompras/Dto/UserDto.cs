using System;

namespace Sistemacompras.Dto
{
    class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Identification { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
