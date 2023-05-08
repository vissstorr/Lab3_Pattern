using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Pattern.ProductRequest
{
    class FileRequest : Request
    {
        public FileRequest(string text) : base(text)
        {

        }
        protected override string GetName()
        {
            return "File request";
        }
    }
}
