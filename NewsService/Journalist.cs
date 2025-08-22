using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NewsService
{
    [DataContract]
    public sealed class Journalist : Person
    {
        public Journalist(string firstname, string lastname, string affiliation) : base(firstname, lastname)
        {
            Affiliation = affiliation;
        }

        [DataMember]
        public string Affiliation { get; set; }
    }
}
