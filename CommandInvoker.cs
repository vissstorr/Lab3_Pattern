using Lab3_Pattern.Enums;
using Lab3_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Pattern
{
    class CommandInvoker:ICommandInvoker
    {
        private DataOutPut _dataOutput;
        public CommandInvoker(DataOutPut dataOutPut)
        {
            _dataOutput = dataOutPut;

        }
        public Dictionary<Command, Action> RunCommand()
        {
            var dictionarycommand = new Dictionary<Command, Action>()
            {
                {Command.RequestProcessed,  _dataOutput.RequestProcessed },
                {Command.ShowServer, _dataOutput.ShowServer },
                {Command.Exit, _dataOutput.Exit },
            };
            return dictionarycommand;
        }
    }
}
