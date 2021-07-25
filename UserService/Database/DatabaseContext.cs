﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Database.Entities;

namespace UserService.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source = DESKTOP-H6FUKM1\SQLEXPRESS ; 
                                        initial catalog =UserMicroService;
                                        persist security info = True;
                                        user id =sa;
                                        password=deepak");
        }
    }
}
