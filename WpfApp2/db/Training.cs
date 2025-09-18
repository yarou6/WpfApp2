using System;
using System.Collections.Generic;

namespace WpfApp2.db;

public partial class Training
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public DateTime DateOfTraining { get; set; }

    public int Time { get; set; }

    public int IdTypeOfTraining { get; set; }

    public virtual TypeOfTraining IdTypeOfTrainingNavigation { get; set; } = null!;

    public virtual ICollection<Participation> Participations { get; set; } = new List<Participation>();
}
