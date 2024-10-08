
using AutoMapper;
using Core.Entity;
using Core.Enums;
using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;
using System.Reflection.Metadata;
using Utility;

namespace Repository
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<InformationEntity> Informations { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder); 
        }
        public void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasData(new UserEntity()
            {
                Id = new Guid("8669ff31-4c04-4bd7-bcb2-e4b2d4608cb3"),
                Email = "laviedental@admin.com",
                Password = CryptographyUtility.MD5Str("laviedental"),
                Role = (int)UserEnum.UserRole.Administrator,
                Sex = (int)UserEnum.UserSex.Male,
                Name = "Admin",
                Address = "143 Vũ Tông Phan, phường Khương Trung, quận Thanh Xuân, thành phố Hà Nội, Hanoi, Vietnam",
                Phone = "0944 66 6363",
                CreatedBy = new Guid("eeb75e9b-100e-4d78-b8b1-a924dc7eb447"),
                ModifiedBy = new Guid("eeb75e9b-100e-4d78-b8b1-a924dc7eb447"),
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                Delete = false,
            });
        }
    }
}