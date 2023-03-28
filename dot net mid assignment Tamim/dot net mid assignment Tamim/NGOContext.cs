using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using dot_net_mid_assignment_Tamim.Models;

public class NGOContext : DbContext
{
 
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<CollectRequest> CollectRequests { get; set; }
}
