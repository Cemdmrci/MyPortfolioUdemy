using Microsoft.EntityFrameworkCore;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.DAL.Context
{
	public class MyPortfolioContext : DbContext //Dbcontexten miras alacağız dbcontexten bazı metotları ve propertylerimi kullanabileceğim böylelikle
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Bağlantı stringimi vereceğim metot
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-AHMBJB5\\SQLEXPRESS;initial Catalog=MyPortfolioUdemy;integrated Security=true;");
		}
		public DbSet<About> Abouts { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Experience> Experiences { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Portfolio> Portfolios { get; set; }
		public DbSet<Skill> Skills { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
		public DbSet<ToDoList> ToDoLists { get; set; }
	}
}

