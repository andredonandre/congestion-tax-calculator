

using congestion.calculator;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;

namespace Calculator.Infrastructure
{
    public class CMSDbContext : DbContext
    {
        DbSet<City> Cities { get; set; }    
        DbSet<Vehicle> Vehicles { get; set; }    
        DbSet<TaxRule> TaxRules { get; set; }  
        DbSet<TaxableTime> TaxableTimes { get; set;}
        //DbSet<TimeExemptionRule> TimeExemptions { get; set; }    
        //DbSet<VehicleExceptionRule> VehicleExceptions { get; set; }    
        //DbSet<MaximumChargeRule> MaximumCharges { get; set; }
        DbSet<Country> Countries { get; set; }
        
         DbSet<PublicHoliday> PublicHolidays { get; set; }
        public CMSDbContext(DbContextOptions<CMSDbContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ContentDatabase");
        }

    }
}