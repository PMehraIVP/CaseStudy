using System;
using System.Collections.Generic;

namespace Case_Study_2025.Models;

public partial class Eattribute
{
    public int AttId { get; set; }

    public string? AttName { get; set; }

    public int? TabId { get; set; }

    public virtual Etab? Tab { get; set; }
}
