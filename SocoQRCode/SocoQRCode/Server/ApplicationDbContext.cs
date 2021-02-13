using Microsoft.EntityFrameworkCore;
using SocoQRCode.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocoQRCode.Server
{
    public class ApplicationDbContext : DbContext
    {
      //  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       //     : base(options)
       // {
        //}
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OUSR>().HasKey(x => new { x.UserID });            
            modelBuilder.Entity<QRCL>().HasKey(x => new { x.QRCodeID});

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<QRCL> QRCL { get; set; }
        public DbSet<OUSR> OUSR { get; set; }
    }
}
