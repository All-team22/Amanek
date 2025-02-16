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
    public class InsuranceCompanyRepository : Repository<InsuranceCompany> , IInsuranceCompanyRepository
    {
        private readonly ApplicationDbContext context;

        public InsuranceCompanyRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
