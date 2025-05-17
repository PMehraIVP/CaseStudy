using System;
using System.Collections.Generic;

namespace Case_Study_2025.Models;

public partial class Battribute
{
    public int AttId { get; set; }

    public string? AttName { get; set; }

    public int? TabId { get; set; }

    public virtual Btab? Tab { get; set; }
}
