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
    public class InsurancePolicyRepository : Repository<InsurancePolicy>, IInsurancePolicyRepository
    {
        private readonly ApplicationDbContext applicationDb;

        public InsurancePolicyRepository(ApplicationDbContext applicationDb) : base(applicationDb) 
        {
            this.applicationDb = applicationDb;
        }
        public void Update(InsurancePolicy insurancePolicy)
        {
            applicationDb.Update(insurancePolicy);
        }
    }
}
