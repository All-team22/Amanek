using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IUnitOfWorks
    {
         IInsuranceCompanyRepository InsuranceCompanyRepository { get;  }
         IApplicationUserRepository ApplicationUserRepository { get; }
         IInsurancePackageRepository InsurancePackageRepository { get; }
         IPaymentRepository PaymentRepository { get; }
        void Commit ();
    }
}
