using Microsoft.EntityFrameworkCore;
using MvcNetCoreEF.Models;

namespace MvcNetCoreEF.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {

        }

        public DbSet<Hospital> Hospitales { get; set; }
    }
}
