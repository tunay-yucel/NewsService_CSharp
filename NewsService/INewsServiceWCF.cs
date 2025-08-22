using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NewsService
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Schnittstellennamen "INewsServiceWCF" sowohl im Code als auch in der Konfigurationsdatei ändern.
    [ServiceContract]
    public interface INewsServiceWCF
    {
        [OperationContract]
        Task<List<NewsArticle>> GetArticlesAsync(string topic);

        [OperationContract]
        Task<NewsArticle> PostArticleAsync(NewsArticle article);
    }
}
