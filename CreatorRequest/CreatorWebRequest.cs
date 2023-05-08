using Lab3_Pattern.ProductRequest;


namespace Lab3_Pattern.CreatorRequest
{
    class CreatorWebRequest : CreatorRequests
    {
        public override Request CreateProduct(string text)
        {
            return new WebRequest(text);
        }
    }
}
