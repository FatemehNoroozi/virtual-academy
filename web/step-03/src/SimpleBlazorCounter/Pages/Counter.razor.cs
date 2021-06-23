﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlazorCounter.Pages
{
    public partial class Counter
    {
        public int CurrentCount { get; set; }

        public void increase()
        {
            CurrentCount++;
        }

        public void decrease()
        {
            CurrentCount--;
        }
    }
}
