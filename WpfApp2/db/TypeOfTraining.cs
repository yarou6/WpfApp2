using System;
using System.Collections.Generic;

namespace WpfApp2.db;

public partial class TypeOfTraining
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Training> Training { get; set; } = new List<Training>();
}
