using System;
using System.Collections.Generic;

namespace Case_Study_2025.Models;

public partial class Btab
{
    public int TabId { get; set; }

    public string? TabName { get; set; }

    public virtual ICollection<Battribute> Battributes { get; set; } = new List<Battribute>();
}
