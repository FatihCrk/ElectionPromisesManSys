﻿using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    internal class EPromisesManSysContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EPromisesDb;Trusted_Connection = true");
        }
        public DbSet<Promise> Promises { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Party> Parties { get; set; }
               public DbSet<User> Users { get; set; }
        
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        


    }
}
