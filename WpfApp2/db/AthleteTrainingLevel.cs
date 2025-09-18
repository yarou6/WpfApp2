using System;
using System.Collections.Generic;

namespace WpfApp2.db;

public partial class AthleteTrainingLevel
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Athlete> Athletes { get; set; } = new List<Athlete>();
}
