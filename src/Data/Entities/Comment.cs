using MSS_NewsWeb.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;

namespace SportsStore.Data.Entities
{
    public class Comment : BaseEntity
    {
        public AppUser AppUser { get; set; }

        public int AppUserId { get; set; }

        public Post Post { get; set; }

        public int PostId { get; set; }

        public string Content_ { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}
