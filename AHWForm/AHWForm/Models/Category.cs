﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace AHWForm.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public int? ParentCategoryId { get; set; }
        public string Name { get; set; }
    }

    public class CategoryContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
    }
}