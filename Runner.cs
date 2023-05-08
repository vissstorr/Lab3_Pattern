using Lab3_Pattern.Enums;
using System;

namespace Lab3_Pattern
{
    class Runner 
    {
        private CommandInvoker _commandInvoker;
        public Runner(CommandInvoker commandInvoker)
        {
            _commandInvoker = commandInvoker;
        }
        public void Run()
        {
            while (true)
            {
                Console.Write("\t1-Написати запит до серверу. 2 - Вивести сервери. Вихід - 0. ");
                if (Enum.TryParse(Console.ReadLine(), out Command command) && _commandInvoker.RunCommand().ContainsKey(command))
                {
                    _commandInvoker.RunCommand()[command]();
                }
                else
                {
                    Console.WriteLine("НЕ вірно ведене число , введіть число від 1-2");
                }
            }

        }

    }
}
