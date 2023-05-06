using System;
using System.Collections.Generic;

namespace TheTheatre;

public partial class TheatreWorker
{
    public int TheatreWorkerId { get; set; }

    public string? Fullname { get; set; }

    public int? Experience { get; set; }

    public int PositionId { get; set; }

    public Position Position { get; set; } = null!;

    public ICollection<Show> Shows { get; set; } = new List<Show>();
    public ICollection<Role> Roles { get; set; } = new List<Role>();

}
