using AutoMapper;
using ReletionshipRepstryType.WebApp.DatabaseContext;
using ReletionshipRepstryType.WebApp.Models;
using ReletionshipRepstryType.WebApp.Services;
using ReletionshipRepstryType.WebApp.ViewModel;

namespace ReletionshipRepstryType.WebApp.RepositoryServices
{
    public class EmployeeRepository : RepositoryService<Employee, EmployeeVm>, IEmployeeRepository
    {
        public EmployeeRepository(IMapper mapper, ApplicationDbContext dbContext) : base(mapper, dbContext)
        {
        }
    }
}
