using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataAccess.Repository.IRepository
{
    public interface IInsuranceCompanyRepository : IRepository<InsuranceCompany>
    {
        void Update(InsuranceCompany company);
    }
}
