using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Pattern
{
    public abstract class Request
    {
        public int Id { get; set; }
        public DateTime TimeCreat { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }
        private static List<int> UsedIds = new List<int>();
        public Request(string text)
        {
            Id = GenerateUniqueId();
            TimeCreat = DateTime.Now;
            Text = text;

        }
        private static int GenerateUniqueId()
        {
            Random random = new Random();
            int id = random.Next(1, 101);
            while (UsedIds.Contains(id))
            {
                id = random.Next(1, 101);
            }
            UsedIds.Add(id);
            return id;
        }
        protected abstract string GetName();
        public override string ToString()
        {
            return $"{Id} був створення{TimeCreat}  . Текст запиту {Text}";
        }
    }
}
