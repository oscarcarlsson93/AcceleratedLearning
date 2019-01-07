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

        internal ShowComments(BlogPost blogpost)
        {
            var sql = @"Select * FROM Comments where BlogpostId = @Id";

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
                        Title = reader.GetSqlString(2).Value
                    };
                    return blogPost;
                }
                return null;
            }
        }
    }
}
