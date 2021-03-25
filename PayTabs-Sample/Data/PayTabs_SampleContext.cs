using System;
using Microsoft.EntityFrameworkCore;
using PayTabs_Sample.Models;

namespace PayTabs_Sample.Data
{
    public class PayTabs_SampleContext : DbContext
    {
        public PayTabs_SampleContext(DbContextOptions<PayTabs_SampleContext> options)
            : base(options)
        {
        }

        public DbSet<Transaction> Transaction { get; set; }
    }
}
