using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Pattern
{
    class FileServer : Server
    {
        public FileServer(int id) : base(id){}
        protected override string GetName()
        {
            return "File";
        }
    }
}
