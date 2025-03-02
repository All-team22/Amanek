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
    public class InsurancePackageRepository : Repository<InsurancePackage>, IInsurancePackageRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public InsurancePackageRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
      

        public void Update(InsurancePackage insurancePackage)
        {
            var packageFromDB = context.InsurancePackages.FirstOrDefault(e => e.Id == insurancePackage.Id);
            if (packageFromDB != null) { 
                packageFromDB.PackageName = insurancePackage.PackageName;
                packageFromDB.PaymentFrequency = insurancePackage.PaymentFrequency;
                packageFromDB.MaintenanceSchedule = insurancePackage.MaintenanceSchedule;
                packageFromDB.PolicyPrice = insurancePackage.PolicyPrice;
            }
        }
    }
}
