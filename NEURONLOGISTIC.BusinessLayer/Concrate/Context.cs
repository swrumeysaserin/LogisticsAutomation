using Microsoft.EntityFrameworkCore;
using NEURONLOGISTIC.EntityLayer.Concrate.Definations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEURONLOGISTIC.BusinessLayer.Concrate
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-A5FI6ME\\SQLEXPRESS; database=NEURONLOGISTIC4; uid=sa; pwd=12345");
        }

        public DbSet<Airline> Airlines { get; set; }
        
        public DbSet<Airport> Airports { get; set; }
        
        public DbSet<Branch> Branches { get; set; }
        
        public DbSet<CargoType> CargoTypes { get; set; }
        
        public DbSet<City> Cities { get; set; }
        
        public DbSet<Company> Companies { get; set; }
        
        public DbSet<CompanyType> CompanyTypes { get; set; }
        
        public DbSet<Container> Containers { get; set; }
        
        public DbSet<Country> Countries { get; set; }
        
        public DbSet<Currency> Currencies { get; set; }
        
        public DbSet<Customs> Customss { get; set; }
        
        public DbSet<CustomsType> CustomsTypes { get; set; }
        
        public DbSet<Employee> Employees { get; set; }
        
        public DbSet<EntityStatus> EntityStatuses { get; set; }
        
        public DbSet<InvoiceType> InvoiceTypes { get; set; }
        
        public DbSet<Line> Lines { get; set; }
        
        public DbSet<PackageType> PackageTypes { get; set; }
        
        public DbSet<PaymentType> PaymentTypes { get; set; }
        
        public DbSet<Port> Ports { get; set; }
        
        public DbSet<Role> Roles { get; set; }
        
        public DbSet<Ship> Ships { get; set; }
        
        public DbSet<ShipmentType> ShipmentTypes { get; set; }
        
        public DbSet<Term> Terms { get; set; }
        
        public DbSet<Voyage> Voyages { get; set; }
    }
}