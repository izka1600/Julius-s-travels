using System;
using System.Collections.Generic;

#nullable disable

namespace WebJourneys.Database
{
    public partial class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatorId { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
    }
}
