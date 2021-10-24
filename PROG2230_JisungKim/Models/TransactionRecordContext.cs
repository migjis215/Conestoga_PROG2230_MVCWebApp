/* TransactionRecordContext.cs
 * Class that generates database tables and seeds initial data
 * Revision History
 *      Jisung Kim, 2021.09.28: Created 
 *      Jisung Kim, 2021.10.14: Edited
 *      
 */

using Microsoft.EntityFrameworkCore;

namespace PROG2230_JisungKim.Models
{
    public class TransactionRecordContext : DbContext
    {
        public TransactionRecordContext(DbContextOptions<TransactionRecordContext> options) : base(options) { }

        public DbSet<TransactionRecord> TransactionRecords { get; set; }
        public DbSet<TransactionType> TransactionTypes { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    CompanyId = 1,
                    Name = "Google",
                    Address = "123 Google Way",
                    TickerSymbol = "GOOG"
                },
                new Company
                {
                    CompanyId = 2,
                    Name = "Microsoft",
                    Address = "453 Bill Gates Drive",
                    TickerSymbol = "MSFT"
                }
            );
            modelBuilder.Entity<TransactionType>().HasData(
                new TransactionType
                {
                    TransactionTypeId = 1,
                    Name = "Buy",
                    CommissionFee = 5.40
                },
                new TransactionType
                {
                    TransactionTypeId = 2,
                    Name = "Sell",
                    CommissionFee = 5.99
                }
            );

            modelBuilder.Entity<TransactionRecord>().HasData(
                new TransactionRecord
                {
                    TransactionRecordId = 1,
                    CompanyId = 1,
                    Quantity = 100,
                    SharePrice = 123.45,
                    TransactionTypeId = 1
                },
                new TransactionRecord
                {
                    TransactionRecordId = 2,
                    CompanyId = 2,
                    Quantity = 100,
                    SharePrice = 2701.76,
                    TransactionTypeId = 2
                }
            );
        }
    }
}
