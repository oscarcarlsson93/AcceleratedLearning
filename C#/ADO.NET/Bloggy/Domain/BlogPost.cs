using System;
using System.Collections.Generic;
using System.Text;

namespace Bloggy.Domain
{
    class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }
        public DateTime Updated { get; set; }
        public string AuthorName { get; set; }

        public List<Comment> Comments { get; set; }
        


    }
}
