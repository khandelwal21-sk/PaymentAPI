using Microsoft.EntityFrameworkCore;

namespace PaymentAPi.Models
{
    public class PaymentDetailsContext : DbContext
    {
        public PaymentDetailsContext(DbContextOptions options) : base(options)
        {

        }
        public  DbSet<PaymentDetails> PaymentDetails { get; set; }
    }
}
