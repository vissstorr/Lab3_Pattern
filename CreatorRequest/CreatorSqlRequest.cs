namespace Lab3_Pattern.CreatorRequest
{
    class CreatorSqlRequest : CreatorRequests
    {
        public override Request CreateProduct(string text)
        {
            return new SqlRequest(text);
        }
    }
}
