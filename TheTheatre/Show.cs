using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheTheatre;

public partial class Show
{
    [Key]
    public string? ShowName { get; set; }

    public float? Duration { get; set; }

    public int? Minprice { get; set; }

    public int? Maxprice { get; set; }

    public string? Hall { get; set; }

    public string? Description { get; set; }

    public ICollection<TheatreWorker> TheatreWorkers { get; set; } = new List<TheatreWorker>();
    public ICollection<Role> Roles { get; set; } = new List<Role>();

}
