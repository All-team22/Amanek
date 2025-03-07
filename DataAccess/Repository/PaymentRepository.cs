using Data_Access;
using DataAccess.Repository.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class PaymentRepository : Repository<Payment>, IPaymentRepository
    {
        private readonly ApplicationDbContext dbContext;

        public PaymentRepository(ApplicationDbContext dbContext) : base(dbContext) 
        {
            this.dbContext = dbContext;
        }
        public void Update(Payment payment)
        {
           dbContext.Update(payment);
        }
    }
}
