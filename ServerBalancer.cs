using Lab3_Pattern.Enums;
using Lab3_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3_Pattern
{
    public class ServerBalancer:IServerBalancer
    {
        public Dictionary<ServerType, List<Server>> _newServers;
        private IDataContent _dataServer;
        public ServerBalancer(DataContent dataServer)
        {
            _dataServer = dataServer;
            _newServers = NewServers();
        }
        private Dictionary<ServerType, List<Server>> NewServers()
        {
            Dictionary<ServerType, List<Server>> servers = new Dictionary<ServerType, List<Server>>();
            var fileServers = _dataServer.FileServers;
            servers.Add(ServerType.FileServer, fileServers);
            var sqlServers = _dataServer.SqlServers;
            servers.Add(ServerType.SqlServer, sqlServers);
            var webServers = _dataServer.WebServers;
            servers.Add(ServerType.WebServer, webServers);
            return servers;
        }
        public void AssignRequestToServerType(Request request, ServerType serverType)
        {
            List<Server> serversOfType = new List<Server>();
            switch (serverType)
            {
                case ServerType.FileServer:
                    serversOfType = _newServers[ServerType.FileServer];
                    break;
                case ServerType.SqlServer:
                    serversOfType = _newServers[ServerType.SqlServer];
                    break;
                case ServerType.WebServer:
                    serversOfType = _newServers[ServerType.WebServer];
                    break;
            }
            Server server = serversOfType.FirstOrDefault(s => s.IsAvailable());
            if (server != null)
            {
                server.AssignRequest(request);
                ChangeServerState(server);
                UpdateServer(server,serverType);
                Console.WriteLine($"Запит :{request.Text}. \n Id : {request.Id} до {serverType} id : {server.Id} в : {request.TimeCreat}. ");   
            }
            else
            {
                Console.WriteLine($"Немає доступних  {serverType} для запиту {request.Id}");
            }
        }
       
        public void ChangeServerState(Server server)
        {
            if (server.AssignedRequest != null)
            {
                server.ChangeState(false);
            }
        }
      
        public void UpdateServer(Server server, ServerType serverType)
        {
            if (_newServers.ContainsKey(serverType))
            {
                var serverList = _newServers[serverType];
                var index = serverList.FindIndex(s => s.Id == server.Id);
                if (index != -1)
                {
                    serverList[index].UpdateFrom(server);
                }
            }
        }
       
    }
}
