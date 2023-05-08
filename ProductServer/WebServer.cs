using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Pattern
{
    class WebServer : Server
    {
        public WebServer(int id) : base(id)
        {
        }

        protected override string GetName()
        {
            return "Web";
        }
    }
}
