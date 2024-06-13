using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-9K4NS1H\\SQLEXPRESS; initial catalog=ApiDb; integrated security=True; TrustServerCertificate=true;");
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Booking>()
				.Property(b => b.Description)
				.IsRequired(false); // Description alanını opsiyonel hale getirme

			modelBuilder.Entity<Booking>()
				.Property(b => b.CheckIn)
				.HasColumnType("date"); // CheckIn alanını sadece tarih olarak ayarlama

			modelBuilder.Entity<Booking>()
				.Property(b => b.CheckOut)
				.HasColumnType("date"); // CheckOut alanını sadece tarih olarak ayarlama
		}

		public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
		public DbSet<Guest> Guests { get; set; }
		public DbSet<Contact> Contacts { get; set; }
	}
}
