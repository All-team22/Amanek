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

        public void Update(InsuranceCompany company)
        {
            var companyFromDb = context.InsuranceCompanies.FirstOrDefault(e => e.Id == company.Id);

            if (companyFromDb != null)
            {
                companyFromDb.Name = company.Name;
                companyFromDb.Phone = company.Phone;
                companyFromDb.RegistrationNumber = company.RegistrationNumber;
                companyFromDb.ContactEmail = company.ContactEmail;
                companyFromDb.Location = company.Location;
                companyFromDb.Website = company.Website;
            }
        }
    }
}
