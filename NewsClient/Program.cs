using NewsClient.NewsClientRef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewsClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            NewsServiceWCFClient client = new NewsServiceWCFClient("BasicHttpBinding_INewsServiceWCF");
            NewsServiceWCFClient client2 = new NewsServiceWCFClient("NetTcpBinding_INewsServiceWCF");

            try
            {
                var list = await client.GetArticlesAsync("Weed");
                foreach (var i in list)
                {
                    Console.WriteLine(i);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                var neuearticel = client2.PostArticle(new NewsArticle { Topic = "Darts", Date = new DateTime(2012, 9, 5), Text = "Darts ist underrated", PostedBy = new Journalist { Firstname = "Fritz", Lastname = "Fischer", Affiliation = "ka" } });
                Console.WriteLine("new article: ");
                Console.WriteLine(neuearticel);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
    }
}
