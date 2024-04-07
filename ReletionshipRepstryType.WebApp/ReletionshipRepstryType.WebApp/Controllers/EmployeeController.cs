using Microsoft.AspNetCore.Mvc;
using ReletionshipRepstryType.WebApp.RepositoryServices;
using ReletionshipRepstryType.WebApp.ViewModel;

namespace ReletionshipRepstryType.WebApp.Controllers
{
    public class EmployeeController(IEmployeeRepository employeeRepository) : Controller
    {
       



        [HttpGet]
        public async Task<ActionResult<EmployeeVm>> Index()
        {
            var data = await employeeRepository.GetAllAsync();
            return View(data);
        }
        [HttpGet]
        public async Task<ActionResult<EmployeeVm>> CreateOrEdit(long id, CancellationToken cancellation)
        {
            
            if (id == 0)
            {
                return View(new EmployeeVm());

            }
            else
            {
                return View(await employeeRepository.GetByIdAsync(id, cancellation));
            }
        }
        [HttpPost]
        public async Task<ActionResult<StateVm>> CreateOrEdit(long id, EmployeeVm EmployeeVm, CancellationToken cancellation)
        {
            if (id == 0)
            {
                await employeeRepository.InsertAsync(EmployeeVm, cancellation);
                return RedirectToAction(nameof(Index));

            }
            else
            {
                await employeeRepository.UpdateAsync(id, EmployeeVm, cancellation);
                return RedirectToAction(nameof(Index));
            }
        }

        public async Task<ActionResult<StateVm>> Delete(long id, CancellationToken cancellation)
        {
            if (id != 0)
            {
                await employeeRepository.DeleteAsync(id, cancellation);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }




    }
}
