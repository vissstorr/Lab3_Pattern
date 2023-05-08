using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Pattern
{
    class SqlRequest : Request
    {
        public SqlRequest(string text) : base( text)
        {

        }
        protected override string GetName()
        {
            return "Sql request";
        }
    }
}
