﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Training
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateOnly DateOfTraining { get; set; }
        public int Time {  get; set; }

        public string Type { get; set; }

    }
}
