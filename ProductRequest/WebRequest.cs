using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Pattern.ProductRequest
{
    class WebRequest:Request
    {
        public WebRequest(string text) : base( text)
        {

        }
        protected override string GetName()
        {
            return "Web request";
        }
    }
}
