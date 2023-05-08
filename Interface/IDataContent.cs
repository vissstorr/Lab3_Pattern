using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Pattern.Interface
{
    interface IDataContent
    {
        List<Server> FileServers { get;}
        List<Server> SqlServers { get; }
        List<Server> WebServers { get; }
    }
}
