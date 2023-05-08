using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Pattern
{
    class SqlServer : Server
    {
        public SqlServer(int id) : base(id)
        {
        }
        protected override string GetName()
        {
            return "Sql";
        }
    }
}
