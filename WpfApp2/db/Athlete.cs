using System;
using System.Collections.Generic;

namespace WpfApp2.db;

public partial class Athlete
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly Birthday { get; set; }

    public int IdAthleteCategory { get; set; }

    public int IdAthleteSTrainingLevel { get; set; }

    public virtual AthleteCategory IdAthleteCategoryNavigation { get; set; } = null!;

    public virtual AthleteTrainingLevel IdAthleteSTrainingLevelNavigation { get; set; } = null!;

    public virtual ICollection<Participation> Participations { get; set; } = new List<Participation>();
}
