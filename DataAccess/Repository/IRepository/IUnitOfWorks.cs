using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IUnitOfWorks
    {
        public IInsuranceCompanyRepository InsuranceCompanyRepository { get;  }
        IApplicationUserRepository ApplicationUserRepository { get; }
        void Commit ();
    }
}
