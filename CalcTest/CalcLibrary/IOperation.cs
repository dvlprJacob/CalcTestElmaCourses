﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{
    public interface IOperation
    {
        string Name { get; }

        double Calc(int x, int y);
    }

    public interface IOperationArgs : IOperation
    {
        double Calc(IEnumerable<int> args);
    }
}
