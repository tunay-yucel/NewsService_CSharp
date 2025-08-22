using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NewsClient.NewsClientRef
{

    public partial class Journalist
    {
        public override string ToString()
        {
            return $"{Firstname} - {Lastname} - {Affiliation}";
        }
    }
}
