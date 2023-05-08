using Lab3_Pattern.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Pattern.Interface
{
    interface IServerBalancer
    {
        void AssignRequestToServerType(Request request, ServerType serverType);
        void ChangeServerState(Server server);
        void UpdateServer(Server server, ServerType serverType);

    }
}
