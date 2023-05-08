using Lab3_Pattern.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Pattern.Interface
{
    interface ICommandInvoker
    {
        Dictionary<Command, Action> RunCommand();
    }
}
