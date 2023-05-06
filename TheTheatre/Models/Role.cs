using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheTheatre.Models;

public partial class Role
{
    public string? RoleName { get; set; }

    public string? ShowName { get; set; }
    [ForeignKey("ShowName")]
    public Show Show { get; set; } = null!;

    public int TheatreWorkerId { get; set; }
    public TheatreWorker TheatreWorker { get; set; } = null!;
}
