using NewsClient.NewsClientRef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NewsClient.NewsClientRef
{

    public partial class NewsArticle
    {
        public override string ToString()
        {
            return $"{Topic} - {Date} - {Text} - {PostedBy}";
        }
    }
}