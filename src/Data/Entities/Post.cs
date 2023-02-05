using MSS_NewsWeb.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace SportsStore.Data.Entities
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }

        public string Defination1 { get; set; }

        public string Defination2 { get; set; }

        public string MediaPath { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public DateTime CreatedTime { get; set; }

        public AppUser AppUser { get; set; }

        public int AppUserId { get; set; }

        //

        public List<Comment> Comments { get; set; }
    }
}
