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
        }
        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
