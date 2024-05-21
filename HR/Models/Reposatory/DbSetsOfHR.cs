using HR.DataCore;
using HR.Models.DataCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HR.Models.Reposatory
{
    public class DbSetsOfHR :DbContext
    {
        public DbSetsOfHR(DbContextOptions<DbSetsOfHR> options) : base(options) 
        {
            
        }
        public DbSet<Emplye> emplyes { get; set; }
        public DbSet<DepartmentInformations> Departments { get; set; }
        public DbSet<CampInformation> CampInformation { get; set; }

    }
}
