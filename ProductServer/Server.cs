using System;

namespace Lab3_Pattern
{
    public abstract class Server
    {
        public int Id { get; }
        public string Name { get; }

        public Request AssignedRequest;
        public bool IsOnline { get; set; }
        public Server(int id)
        {
            Name = GetName();
            Id = id;
            AssignedRequest = null;
            IsOnline = true;
        }
      
        public void AssignRequest(Request request)
        {
            this.AssignedRequest = request;
        }
        public void ChangeState(bool isOnline)
        {
            this.IsOnline = isOnline;
        }
       
        public bool IsAvailable()
        {
            return IsOnline==true && this.AssignedRequest == null;
        }
        public override string ToString()
        {
            return $"{Name} server {Id} ";
        }
        protected abstract string GetName();

        public void UpdateFrom(Server server)
        {
            this.IsOnline = server.IsOnline;
            this.AssignedRequest = server.AssignedRequest;
        }
    }
}
