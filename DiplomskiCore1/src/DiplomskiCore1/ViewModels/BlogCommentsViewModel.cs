﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DiplomskiCore1.Models;

namespace DiplomskiCore1.ViewModels
{
    public class BlogCommentsViewModel
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public bool Like { get; set; }

        public bool Dislike { get; set; }

        public int NumberOfLike { get; set; }

        public int NumberOfDisike { get; set; }

        [Display(Name = "New Comment")]
        public string NewCommentText { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}
