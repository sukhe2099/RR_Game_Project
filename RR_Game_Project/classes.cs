﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRRR
{
    public partial class classes : Component
    {
        public classes()
        {
            InitializeComponent();
        }

        public classes(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
