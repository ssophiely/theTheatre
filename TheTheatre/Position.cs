using System;
using System.Collections.Generic;

namespace TheTheatre;

public partial class Position
{
    public int PositionId { get; set; }

    public string? PosName { get; set; }

    public ICollection<TheatreWorker> TheatreWorkers { get; set; } = new List<TheatreWorker>();
}
