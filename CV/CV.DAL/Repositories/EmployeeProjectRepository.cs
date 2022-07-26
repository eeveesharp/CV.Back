using CV.DAL.EF;
using CV.DAL.Entities;

namespace CV.DAL.Repositories
{
    public class EmployeeProjectRepository : GenericRepository<EmployeeProjectEntity>
    {
        public EmployeeProjectRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
