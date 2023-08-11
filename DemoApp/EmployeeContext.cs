using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        //	For helping set up the Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //	See URL: https://learn.microsoft.com/en-us/dotnet/api/microsoft.data.sqlclient.sqlconnectionstringbuilder.trustservercertificate?view=sqlclient-dotnet-standard-5.1
            //	See URL: https://stackoverflow.com/questions/510899/multipleactiveresultsets-true-or-multiple-connections
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=RankenEmps;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        //  Creating the "seed" data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //	See URL: https://learn.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.onconfiguring?view=efcore-7.0
            //	See URL: https://learn.microsoft.com/en-us/dotnet/api/system.data.entity.dbcontext.onmodelcreating?view=entity-framework-6.2.0

            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeID = 1, FirstName = "Jeff", LastName = "Scott", DeptName = "AWD", Salary = 34567.00m },
                new Employee { EmployeeID = 2, FirstName = "Evan", LastName = "Gudmestad", DeptName = "AWD", Salary = 78901.00m },
                new Employee { EmployeeID = 3, FirstName = "Tom", LastName = "Anderson", DeptName = "IT", Salary = 56789.00m },
                new Employee { EmployeeID = 4, FirstName = "Ashley", LastName = "Reddick", DeptName = "IT", Salary = 77777.00m },
                new Employee { EmployeeID = 5, FirstName = "Charles", LastName = "Corrigan", DeptName = "ADM", Salary = 98765.00m }
            );
        }
    }
}
