using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bloggy.Domain;

namespace Bloggy
{
    public class DataAccess
    {
        private string conString = "Server=(localdb)\\mssqllocaldb; Database=Blogposts";

        internal List<BlogPost> GetAllBlogPostsBrief()
        {

            var sql = @"SELECT BlogpostId, Name, Title
                        FROM Blogpost
                        JOIN Author on Blogpost.AuthorId = Author.AuthorId";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                var list = new List<BlogPost>();

                while (reader.Read())
                {
                    var bp = new BlogPost
                    {
                        Id = reader.GetSqlInt32(0).Value,
                        AuthorName = reader.GetSqlString(1).Value,
                        Title = reader.GetSqlString(2).Value
                    };
                    list.Add(bp);
                }

                return list;
            }
        }


        internal void UpdateBlogpost(BlogPost blogpost)
        {
            var sql = @"UPDATE Blogpost
                        SET Title = @Title
                        WHERE BlogpostId = @Id";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Title", blogpost.Title));
                command.Parameters.Add(new SqlParameter("Id", blogpost.Id));

                command.ExecuteNonQuery();
            }
        }

        internal List<Comment> GetCommentsForBlogPost(int id)
        {
            var sql = @"Select Text, Name FROM Comments
                 Join Author on Author.AuthorId = Comments.AuthorId
                    Where BlogpostId = @Id";
             

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", id));

                SqlDataReader reader = command.ExecuteReader();

                var list = new List<Comment>();

                while (reader.Read())
                {
                    var bp = new Comment
                    {
                        
                        Text = reader.GetSqlString(0).Value,
                        AuthorName = reader.GetSqlString(1).Value
                    };
                    list.Add(bp);
                }

                return list;
            }
        }

        internal BlogPost GetPostsWithSameTag(int postId)
        {
            var sql = @"Select Title from Tags join Blogpost on Blogpost.BlogpostId = Tags.TagId Where TagId = @Id";

                    using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", postId));


                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    var blogPost = new BlogPost
                    {
                       
                        Title = reader.GetSqlString(0).Value,
                        
                    };
                    return blogPost;
                }
                return null;
            }
        }

        internal List<Tags> GetAllTags()
        {
            var sql = @"Select Name, TagId from Tags Join Blogpost on Blogpost.BlogpostId = Tags.TagId";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                var list = new List<Tags>();

                while (reader.Read())
                {
                    var bp = new Tags
                    {
                        Name = reader.GetSqlString(0).Value,
                        TagId = reader.GetSqlInt32(1).Value,
                    };
                    list.Add(bp);
                }
                return list;
            }
        }

        internal int AddNewAuthor(Author commentAuthor)
        {
            var sql = @"Insert into Author(Name) OUTPUT INSERTED.AuthorId VALUES (@Name)";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Name", commentAuthor.Name));
               

                int authorId = (int)command.ExecuteScalar();
                return authorId;
            }
        }

        internal void AddNewComment(Comment blogPost, int postId, int authorId)
        {
            var sql = @"INSERT into Comments(Text, BlogpostId, AuthorId) VALUES (@Text, @Id, @AuthorId)";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Text", blogPost.Text));
                command.Parameters.Add(new SqlParameter("Id", postId));
                command.Parameters.Add(new SqlParameter("AuthorId", authorId));

                command.ExecuteNonQuery();
            }

        }
        internal void RemoveBlog(BlogPost blogpost)
        {
            var sql = @"DELETE FROM Blogpost WHERE BlogpostId = @Id";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", blogpost.Id));

                command.ExecuteNonQuery();
            }
        }

        internal BlogPost GetPostById(int postId)
        {
            var sql = @"SELECT BlogpostId, AuthorId, Title
                        FROM Blogpost WHERE BlogpostId=@Id";


            List<Comment> comments = GetCommentsForBlogPost(postId);

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("Id", postId));

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    var blogPost = new BlogPost
                    {
                        Id = reader.GetSqlInt32(0).Value,
                        AuthorId = reader.GetSqlInt32(1).Value,
                        Title = reader.GetSqlString(2).Value,
                        Comments = comments
                    };
                    return blogPost;
                }
                return null;
            }
        }
    }
}
