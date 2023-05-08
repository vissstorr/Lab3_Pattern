using Lab3_Pattern.Interface;
using System.Collections.Generic;


namespace Lab3_Pattern
{
    public class DataContent : IDataContent
    {
        public List<Server> FileServers => new List<Server>
        {
           new FileServer(1),
           new FileServer(2),
           new FileServer(3),
           new FileServer(4),
           new FileServer(5),
        };
        public List<Server> SqlServers => new List<Server>
        {
          new SqlServer(1),
          new SqlServer(2),
          new SqlServer(3),
          new SqlServer(4),
          new SqlServer(5),
        };
        public List<Server> WebServers => new List<Server>
        {
          new WebServer(1),
          new WebServer(2),
          new WebServer(3),
          new WebServer(4),
        }; 
    }
}
