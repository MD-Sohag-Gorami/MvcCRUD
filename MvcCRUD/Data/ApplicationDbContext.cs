﻿using Microsoft.EntityFrameworkCore;
using MvcCRUD.Models;

namespace MvcCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
