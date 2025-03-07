using Data_Access;
using DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UnitOfWorks : IUnitOfWorks
    {
        private readonly ApplicationDbContext context;

        public UnitOfWorks(ApplicationDbContext context)
        {
            this.context = context;
            InsuranceCompanyRepository = new InsuranceCompanyRepository(context);
            ApplicationUserRepository = new ApplicationUserRepository(context);
            InsurancePackageRepository = new InsurancePackageRepository(context);
            PaymentRepository = new PaymentRepository(context);
        }

        public IInsuranceCompanyRepository InsuranceCompanyRepository {  get; private set; }

        public IApplicationUserRepository ApplicationUserRepository { get; private set; }

        public IInsurancePackageRepository InsurancePackageRepository { get; private set; }

        public IPaymentRepository PaymentRepository { get; private set; }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
