﻿using CV.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CV.DAL.EF
{
    public class ApplicationContext : DbContext
    {
        public DbSet<EmployeeEntity> Employees { get; set; } = null!;
        public DbSet<ProjectEntity> Projects { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.Migrate();
        }
    }
}