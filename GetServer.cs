using Lab3_Pattern.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Pattern
{
    public class GetServer
    {
        private ServerBalancer _serverBalancer;
        public void GetServerStatus(ServerType serverType)
        {
            if (_serverBalancer._newServers.ContainsKey(serverType))
            {
                foreach (var server in _serverBalancer._newServers[serverType])
                {
                    var requestInfo = server.AssignedRequest != null ?
                                      $"запит: {server.AssignedRequest.Id} - {server.AssignedRequest.Text}" :
                                      "немає запиту";
                    Console.WriteLine($"{server} ({server.IsOnline}) призначений: {requestInfo}");
                }
            }
            else
            {
                Console.WriteLine($"Тип серверу {serverType} не знайдено.");
            }
        }
    }
}
