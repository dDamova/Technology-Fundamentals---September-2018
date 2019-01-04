using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int articlesCount = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < articlesCount; i++)
            {
                string[] articleInfo = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                articles.Add(new Article(articleInfo));
            }
            string criteria = Console.ReadLine();

            switch (criteria)
            {
                case "title":

                    foreach (Article article in articles.OrderBy(a => a.Title))
                    {
                        Console.WriteLine(article.ToString());
                    }
                    break;
                case "content":

                    foreach (Article article in articles.OrderBy(a => a.Content))
                    {
                        Console.WriteLine(article.ToString());
                    }
                    break;
                case "author":

                    foreach (Article article in articles.OrderBy(a => a.Author))
                    {
                        Console.WriteLine(article.ToString());
                    }
                    break;
            }
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string[] articleInfo)
        {
            this.Title = articleInfo[0];
            this.Content = articleInfo[1];
            this.Author = articleInfo[2];
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
