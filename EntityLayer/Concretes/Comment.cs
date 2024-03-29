﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concretes
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentUser { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentContent { get; set; }
        public bool CommentState { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; } //bağlama işlemi primary key
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
    }
}
