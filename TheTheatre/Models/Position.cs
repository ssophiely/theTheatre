using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheTheatre.Models;

public partial class Position
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PositionId { get; set; }

    public string? PosName { get; set; }

    public ICollection<TheatreWorker> TheatreWorkers { get; set; } = new List<TheatreWorker>();
}
