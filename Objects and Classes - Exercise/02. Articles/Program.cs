using System;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleData = Console.ReadLine()
                .Split(", ")
                .ToArray();
            int n = int.Parse(Console.ReadLine());

            string title = articleData[0];
            string content = articleData[1];
            string author = articleData[2];

            Article article = new Article(title, content, author);

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (command == "Edit")
                {
                    string newContent = tokens[1];
                    article.Edit(newContent);
                }
                else if (command == "ChangeAuthor")
                {
                    string newAuthor = tokens[1];
                    article.ChangeAuthor(newAuthor);
                }
                else if (command == "Rename")
                {
                    string newTitle = tokens[1];
                    article.Rename(newTitle);
                }
                else if (command == "ToString")
                {
                    author.ToString();
                }
            }
            Console.WriteLine(article.ToString()); ;
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
