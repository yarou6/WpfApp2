using System;
using System.Collections.Generic;

namespace WpfApp2.db;

public partial class Progre
{
    public int Id { get; set; }

    public int Grade { get; set; }

    public string Comment { get; set; } = null!;

    public int IdParticipation { get; set; }

    public virtual Participation IdParticipationNavigation { get; set; } = null!;
}
