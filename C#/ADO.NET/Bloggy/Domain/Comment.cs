using System;
using System.Collections.Generic;
using System.Text;

namespace Bloggy.Domain
{
    class Comment
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Text { get; set; }
        public int BlogpostId { get; set; }
        public DateTime DateTime { get; set; }
        public string AuthorName { get; set; }

    }
}
