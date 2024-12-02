﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Command_Pattern.Commands
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}

