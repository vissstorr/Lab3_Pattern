using Lab3_Pattern.ProductRequest;

namespace Lab3_Pattern.CreatorRequest
{
    class CreatorFileRequest : CreatorRequests
    {
        public override Request CreateProduct(string text)
        {
            return new FileRequest( text);
        }
    }
}
