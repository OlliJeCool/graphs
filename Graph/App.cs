﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class App
    {
        public void Run()
        {
            var matrix = new Matrix();
            matrix.PrintMatrix(5);
            matrix.PrintAsList(5);
        }
    }
}
