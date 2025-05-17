using System;
using System.Collections.Generic;

namespace Case_Study_2025.Models;

public partial class Etab
{
    public int TabId { get; set; }

    public string? TabName { get; set; }

    public virtual ICollection<Eattribute> Eattributes { get; set; } = new List<Eattribute>();
}
