using Microsoft.EntityFrameworkCore;
using atlasCDCPayroll.Models;

namespace atlasCDCPayroll.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Payslip> Payslips { get; set; }
    }
}