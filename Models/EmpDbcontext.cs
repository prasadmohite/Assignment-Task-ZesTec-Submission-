using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EFCore_CF_01.Models
{
    public class EmpDbcontext:IdentityDbContext
    {
        public EmpDbcontext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

    }
}
