using Bloggy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bloggy
{
    public class App

    {
        DataAccess dataAccess = new DataAccess();

        public void Run()
        {
            PageMainMenu();
        }

        private void PageMainMenu()
        {
            Header("Huvudmeny");

            ShowAllBlogPostsBrief();

            WriteLine("Vad vill du göra?");
            WriteLine("a) Gå till huvudmenyn");
            WriteLine("b) Uppdatera en bloggpost");
            WriteLine("c) Ta bort en bloggpost");
            WriteLine("d) Visa kommentarer eller kommentera en bloggpost");
            WriteLine("e) Hantera taggar");

            ConsoleKey command = Console.ReadKey(true).Key; //true gör att värdet inte skrivs ut på skärmen

            if (command == ConsoleKey.A)
                PageMainMenu();

            if (command == ConsoleKey.B)
                PageUpdatePost();

            if (command == ConsoleKey.C)
                DeletePost();

            if (command == ConsoleKey.D)
                CommentPost();

            if (command == ConsoleKey.E)
            {
                BlogPostTags();
            }
        }

        private void BlogPostTags()
        {
            Header("Taggar");

            WriteLine("a) Visa taggar");
            WriteLine("b) Lägg till en tag");
            WriteLine("c) Ta bort en tag");
            WriteLine("d) Gå tillbaka till huvudmenyn");

            ConsoleKey command = Console.ReadKey(true).Key;

            if (command == ConsoleKey.A)
            {
                GetAllTags();
            }
            if (command == ConsoleKey.B)
            {
                AddTag();
            }
            if (command == ConsoleKey.C)
            {
                DeleteTag();
            }
            if (command == ConsoleKey.D) 
            {
                PageMainMenu();
            }
            
            
        }

        private void DeleteTag()
        {
            Header("Ta bort en tagg");

           // ShowTags();
            Console.WriteLine("Ta bort en tag");
            throw new NotImplementedException();
        }

        private void AddTag()
        {
            Header("Lägg till en tag");
            ShowTags();
            throw new NotImplementedException();
        }

        private void GetAllTags()
        {
            Header("Välj tag för att se liknande inlägg");
            ShowTags();
            Console.WriteLine("HEJSAN");
            int postId = int.Parse(Console.ReadLine());
            BlogPost blogpost = dataAccess.GetPostsWithSameTag(postId);

            
        }

        private void ShowTags()
        {
            List<Tags> list = dataAccess.GetAllTags();
            foreach (Tags item in list)
            {
            Console.WriteLine(item.TagId + "      "  + item.Name);

            }

        }

        private void CommentPost()
        {
            Header("Kommentera");


            ShowAllBlogPostsBrief();
            Console.WriteLine("Vilken bloggpost vill du se kommentarerna på?");
            Console.WriteLine();

            int postId = int.Parse(Console.ReadLine());
            BlogPost blogpost = dataAccess.GetPostById(postId);
            Header($"{blogpost.Title} {blogpost.AuthorName}");
            PrintBlogPostComments(blogpost);

            Console.WriteLine();
            Console.WriteLine("Vill du kommentera bloggposten?");
            WriteLine("a) Ja");
            WriteLine("b) Nej(Tillbaka till huvudmenyn)");
            ConsoleKey command = Console.ReadKey(true).Key; //true gör att värdet inte skrivs ut på skärmen
            

            if (command == ConsoleKey.A)
            {
                AddCommentToBlogPost(blogpost, postId);
                Console.WriteLine();
                Console.WriteLine("Din kommentar har nu postats");
                Console.WriteLine();
                
                Thread.Sleep(2000);
                
                PageMainMenu();
            }
            if (command == ConsoleKey.B)
            {
                PageMainMenu();
            }
        }

        private void AddCommentToBlogPost(BlogPost blogPost, int postId)
        {
            Header("Säg vad du tycker!");

            Console.Write("Skriv in ditt namn:");
            string newAuthor = Console.ReadLine();
            Author commentAuthor = new Author() { Name = newAuthor };

            int authorId = dataAccess.AddNewAuthor(commentAuthor);

            Console.WriteLine("Skriv en kommentar: ");
            string newComment = Console.ReadLine();
            Comment commentPost = new Comment() { Text = newComment };


            dataAccess.AddNewComment(commentPost, postId, authorId);

        }

        private void PrintBlogPostComments(BlogPost blogpost)
        {
            foreach (Comment item in blogpost.Comments)
            {
                Console.WriteLine($"{item.Text.PadRight(20)}  {item.AuthorName}");
            }
           
        }

        private void DeletePost()
        {
            Header("Ta bort bloggpost");

            ShowAllBlogPostsBrief();

            Console.Write("Vilken bloggpost vill du ta bort? ");
            int postId = int.Parse(Console.ReadLine());
            BlogPost blogpost = dataAccess.GetPostById(postId);
            dataAccess.RemoveBlog(blogpost);
        }

        private void PageUpdatePost()
        {
            Header("Uppdatera");

            ShowAllBlogPostsBrief();

            Console.Write("Vilken bloggpost vill du uppdatera? ");
            int postId = int.Parse(Console.ReadLine());

            BlogPost blogpost = dataAccess.GetPostById(postId);

            Console.WriteLine($"Den nuvarande titeln är {blogpost.Title}");

            Console.Write("Skriv in ny titel: ");

            string newTitle = Console.ReadLine();

            blogpost.Title = newTitle;

            dataAccess.UpdateBlogpost(blogpost);

            Console.WriteLine("Bloggposten uppdaterad.");
            Console.ReadKey();
            PageMainMenu();
          
        }

        private void ShowAllBlogPostsBrief()
        {

            List<BlogPost> list = dataAccess.GetAllBlogPostsBrief();

            PrintBlogPosts(list);

        }

        private void PrintBlogPosts(List<BlogPost> list)
        {
            foreach (var blogPost in list)
            {
                //WriteLine($"{blogPost.Id.ToString().PadRight(5)}{blogPost.Title.ToString().PadRight(40)}{blogPost.Author}");
                Console.Write(blogPost.Id.ToString().PadRight(5));
                Console.Write(blogPost.Title.ToString().PadRight(40));
                Console.Write(blogPost.AuthorName);
                Console.WriteLine();
            }
                Console.WriteLine();
        }

        private void WriteLine(string text="") //Om man inte skickar in ngn text blir den automatisk tom
        {
            Console.WriteLine(text);
        }

        private void Header(string text)
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text.ToUpper());
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
