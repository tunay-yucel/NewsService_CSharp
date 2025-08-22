using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NewsService
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "NewsServiceWCF" sowohl im Code als auch in der Konfigurationsdatei ändern.
    public class NewsServiceWCF : INewsServiceWCF
    {
        public static List<NewsArticle> articles = new List<NewsArticle>
        {
            new NewsArticle("Rauchfrei", new DateTime(2022, 10, 18), "Es gibt viele Raucher und das wird sich ändern lol", new Person("John", "Werner")),
            new NewsArticle("Burger", new DateTime(2022, 10, 18), "Was ist eigentlich in Burger drinnen? Das wird hier im Artikel näher angeschaut", new Person("John", "Werner")),
            new NewsArticle("Fussball-WM", new DateTime(2022, 10, 18), "Bald beginnt die Fussball WM. Es wird in Quatar abgehalten", new Person("John", "Werner")),
            new NewsArticle("Rassismus", new DateTime(2022, 10, 18), "Heutzutage ist Rassismus sehr zurückgegangen", new Person("John", "Werner")),
            new NewsArticle("Weed", new DateTime(2022, 10, 18), "Weed ist illegal, aber nicht so gefährlich wie Alkohol", new Person("John", "Werner")),
        };
        
        public async Task<List<NewsArticle>> GetArticlesAsync(string topic)
        {
            await Task.Delay(10);

            List<NewsArticle> article = new List<NewsArticle>();

            foreach(var i in articles)
            {
                if(i.Topic == topic)
                {
                    article.Add(i);
                }
            }
            return article;
        }

        public async Task<NewsArticle> PostArticleAsync(NewsArticle newarticle)
        {
            await Task.Delay(10);

            articles.Add(newarticle);

            return newarticle;
        }
    }
}
