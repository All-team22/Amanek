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
    public class ApplicationUserRepository(ApplicationDbContext context) : Repository<ApplicationUser>(context), IApplicationUserRepository
    {
    }
}
