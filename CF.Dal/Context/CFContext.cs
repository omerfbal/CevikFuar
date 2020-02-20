using CF.Map.Options;
using CF.Model;
using CF.Model.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace CF.Dal.Context
{
    public class CFContext : DbContext
    {
        public CFContext() : base("CFConnection")
        {
            //Database.Connection.ConnectionString = "Server = .; Database = CevikFuar; Uid = sa; Pwd = 123";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BrandMap());
            modelBuilder.Configurations.Add(new BrandProductMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new CompanyTypeMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new FairAreaImageMap());
            modelBuilder.Configurations.Add(new FairAreaMap());
            modelBuilder.Configurations.Add(new FairAttendantEmployeeMap());
            modelBuilder.Configurations.Add(new FairInstallEmployeeMap());
            modelBuilder.Configurations.Add(new FairMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new RegionMap());
            modelBuilder.Configurations.Add(new SectorMap());
            modelBuilder.Configurations.Add(new TownMap());
            modelBuilder.Configurations.Add(new VisitorBrandMap());
            modelBuilder.Configurations.Add(new VisitorCompanyTypeMap());
            modelBuilder.Configurations.Add(new VisitorMap());
            modelBuilder.Configurations.Add(new VisitorProductMap());
            modelBuilder.Configurations.Add(new VisitorRegionMap());
            modelBuilder.Configurations.Add(new VisitorSectorMap());
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<Employee> Emplooyees { get; set; }
        public DbSet<Fair> Fairs { get; set; }
        public DbSet<FairArea> FairAreas { get; set; }
        public DbSet<FairAreaImage> FairAreaImages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Visitor> Visitors { get; set; }

        public DbSet<BrandProduct> BrandProducts { get; set; }
        public DbSet<VisitorSector> VisitorSectors { get; set; }
        public DbSet<VisitorRegion> VisitorRegions { get; set; }
        public DbSet<VisitorCompanyType> VisitorCompanyTypes { get; set; }
        public DbSet<FairInstallEmployee> FairInstallEmployees { get; set; }
        public DbSet<FairAttendantEmployee> FairAttendantEmployees { get; set; }
        public DbSet<VisitorBrand> VisitorBrands { get; set; }
        public DbSet<VisitorProduct> VisitorProducts { get; set; }

        public override int SaveChanges()
        {
            var modifiedEntry = ChangeTracker.Entries().Where(x => x.State == EntityState.Modified || x.State == EntityState.Added);

            foreach (var item in modifiedEntry)
            {
                BaseEntity entity = item.Entity as BaseEntity;

                if (item != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        entity.CreatedDate = DateTime.Now;
                        entity.CreatedBy = Guid.NewGuid(); //todo: Kullanıcı sistemi bittikten sonra bu kısım düzeltilecek.
                    }
                    else if (item.State == EntityState.Modified)
                    {
                        entity.ModifiedDate = DateTime.Now;
                        entity.ModifiedBy = Guid.NewGuid(); //todo: Kullanıcı sistemi bittikten sonra bu kısım düzeltilecek.
                    }
                }
            }

            return base.SaveChanges();
        }
    }
}
