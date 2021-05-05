using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CS132MyGram.Models
{
    public class SignUp : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(
                @"Server=(localdb)\mssqllocaldb;Database=MYGRAM;Integrated Security=True");
        }
        public SignUp()
        {

        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int dateOfBirth { get; set; }
        public string gender { get; set; }
    }
}
