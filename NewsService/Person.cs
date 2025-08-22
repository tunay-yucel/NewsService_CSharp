using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NewsService
{
    [DataContract]
    [KnownType(typeof(Journalist))]
    public class Person
    {
        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        [DataMember]
        public string Firstname { get; set; }
        [DataMember]
        public string Lastname { get; set; }
    }
}
