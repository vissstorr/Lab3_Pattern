using Lab3_Pattern.Enums;
using Lab3_Pattern.Interface;
using System;

namespace Lab3_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContent dt = new DataContent();
            ServerBalancer ld = new ServerBalancer(dt);
            DataOutPut dok = new DataOutPut(ld);
            CommandInvoker ci = new CommandInvoker(dok);
            Runner rn = new Runner(ci);
            rn.Run();
            Console.ReadLine();
        }
    }
}
