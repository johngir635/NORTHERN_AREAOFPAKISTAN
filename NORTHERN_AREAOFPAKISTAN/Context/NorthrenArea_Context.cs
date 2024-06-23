using Microsoft.EntityFrameworkCore;
using NORTHERN_AREAOFPAKISTAN.Models;

namespace NORTHERN_AREAOFPAKISTAN.Context
{
    public class NorthrenArea_Context : DbContext
    {
        public NorthrenArea_Context(DbContextOptions<NorthrenArea_Context> options) : base(options) { }
        public DbSet<UserSignupandLogin> UsersData { get; set; }
        public DbSet<ContactFormModel> ContactFormModelData { get; set; }

    }
}
