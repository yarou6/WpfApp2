using System;
using System.Collections.Generic;

namespace WpfApp2.db;

public partial class Participation
{
    public int Id { get; set; }

    public int IdAthlete { get; set; }

    public int IdTraining { get; set; }

    public virtual Athlete IdAthleteNavigation { get; set; } = null!;

    public virtual Training IdTrainingNavigation { get; set; } = null!;

    public virtual ICollection<Progre> Progres { get; set; } = new List<Progre>();
}
