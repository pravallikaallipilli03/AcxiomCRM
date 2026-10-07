using AcxiomCRM.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace AcxiomCRM.Data;
public class ApplicationDbContext: IdentityDbContext<ApplicationUser> {
 public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}
 public DbSet<Customer> Customers=>Set<Customer>(); public DbSet<Lead> Leads=>Set<Lead>(); public DbSet<Opportunity> Opportunities=>Set<Opportunity>(); public DbSet<AuditLog> AuditLogs=>Set<AuditLog>();
}
