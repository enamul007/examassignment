using ExamAssignmentApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamAssignmentApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<AppUser> Users { get; set; }
    public DbSet<DocumentRequest> DocumentRequests { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    base.OnModelCreating(modelBuilder);
    //    string defaultPasswordHash = BCrypt.Net.BCrypt.HashPassword("Password123!");

    //    modelBuilder.Entity<AppUser>().HasData(
    //        new AppUser { Id = 1, Username = "user1", PasswordHash = defaultPasswordHash, Role = "User" },
    //        new AppUser { Id = 2, Username = "checker1", PasswordHash = defaultPasswordHash, Role = "Checker" },
    //        new AppUser { Id = 3, Username = "authorizer1", PasswordHash = defaultPasswordHash, Role = "Authorizer" }
    //    );
    //}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        string defaultPasswordHash = BCrypt.Net.BCrypt.HashPassword("Password123!");

        // ১. AppUser Seed Data
        modelBuilder.Entity<AppUser>().HasData(
            new AppUser { Id = 1, Username = "user1", PasswordHash = defaultPasswordHash, Role = "User" },
            new AppUser { Id = 2, Username = "checker1", PasswordHash = defaultPasswordHash, Role = "Checker" },
            new AppUser { Id = 3, Username = "authorizer1", PasswordHash = defaultPasswordHash, Role = "Authorizer" }
        );

        // ২. DocumentRequest Seed Data (Loop দিয়ে ১০০টি ডেটা জেনারেট করা)
        var requestList = new List<DocumentRequest>();
        for (int i = 1; i <= 100; i++)
        {
            // স্ট্যাটাস একটু ভিন্ন ভিন্ন করার জন্য লজিক (Pending, Checked, Authorized)
            string status = "Pending";
            if (i % 3 == 0) status = "Checked";
            else if (i % 5 == 0) status = "Authorized";

            requestList.Add(new DocumentRequest
            {
                Id = i,
                Title = $"Sample Document Request Title {i}",
                Content = $"This is the detailed content description for document request number {i} used for pagination testing.",
                Status = status,
                CreatedByUserId = 1, // user1-এর আইডি
                CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddHours(i)
            });
        }

        modelBuilder.Entity<DocumentRequest>().HasData(requestList);
    }
}
