﻿using Microsoft.AspNetCore.Identity;
using SportsStore.Data.Entities;

namespace denemeBlazor.Data.Entities
{
    public class AppUser : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public List<Post> Posts { get; set; }

        public List<Comment> Comments { get; set; }

    }
}
