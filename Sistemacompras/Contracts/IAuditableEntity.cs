using System;

namespace Sistemacompras.Contracts
{
    interface IAuditableEntity
    {
        DateTime CreatedDate { get; set; }
        int CreatedBy { get; set; }
        DateTime UpdatedDate { get; set; }
        int UpdatedBy { get; set; }
    }
}
