using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Progress
    {
        public int Id { get; set; }

        public string Grade { get; set; }

        public string Comment { get; set; }

        public List<Progress> Progres { get; set;} = new List<Progress>();
    }
}
