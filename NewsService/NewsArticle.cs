using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NewsService
{
    [DataContract]
    public sealed class NewsArticle
    {
        public NewsArticle(string topic, DateTime date, string text, Person postedBy)
        {
            Topic = topic;
            Date = date;
            Text = text;
            PostedBy = postedBy;
        }
        [DataMember]
        public string Topic { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public Person PostedBy { get; set; }
    }
}
