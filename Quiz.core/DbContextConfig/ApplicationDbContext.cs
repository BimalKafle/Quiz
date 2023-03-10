using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Quiz.core.Mapping;
using Quiz.core.Source.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.DbContextConfig
{
    public class ApplicationDbContext: IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public class OptionBuild
        {

            public OptionBuild()
            {
                Settings = new AppConfiguration();
                OptionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
                OptionBuilder.UseMySql(Settings.MysqlConnectionString, Settings.ServerVersion);
                DBOptions = OptionBuilder.Options;
            }
            public DbContextOptionsBuilder<ApplicationDbContext> OptionBuilder { get; set; }
            public DbContextOptions<ApplicationDbContext> DBOptions { get; set; }
            private AppConfiguration Settings { get; set; }
        }
        public static OptionBuild options = new();



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ApplicationUserMapping());
            modelBuilder.ApplyConfiguration(new AnswerMapping());


        }
        
    }
}
