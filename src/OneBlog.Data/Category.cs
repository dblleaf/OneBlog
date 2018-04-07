﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using OneBlog.Helpers;
using SS.Toolkit.Helpers;

namespace OneBlog.Data
{
    public class Category
    {
        public Category()
        {
            Id = GuidHelper.Gen().ToString();
        }

        [Key]
        [StringLength(100)]
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ParentId { get; set; }

        public virtual IList<PostsInCategories> PostsInCategories { get; set; }
    }
}
