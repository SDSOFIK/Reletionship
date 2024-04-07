using Microsoft.AspNetCore.Mvc;
using ReletionshipRepstryType.WebApp.ModelConfiguration;
using ReletionshipRepstryType.WebApp.RepositoryServices;
using ReletionshipRepstryType.WebApp.ViewModel;

namespace ReletionshipRepstryType.WebApp.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityRepository cityRepository;

        public CityController(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }

        public async Task<ActionResult<CityVm>> Index(CancellationToken cancellation)
        {
            var data = await cityRepository.GetAllAsync(cancellation);
            return View(data);
        }
        [HttpGet]
        public async Task<ActionResult<CityVm>> CreateOrEdit(long id, CancellationToken cancellation)
        {
            if (id == 0)
            {
                return View(new CityVm());

            }
            else
            {
                return View(await cityRepository.GetByIdAsync(id, cancellation));
            }
        }
        [HttpPost]
        public async Task<ActionResult<CityVm>> CreateOrEdit(long id, CityVm cityVm, CancellationToken cancellation)
        {
            if (id == 0)
            {
                await cityRepository.InsertAsync(cityVm, cancellation);
                return RedirectToAction(nameof(Index));

            }
            else
            {
                await cityRepository.UpdateAsync(id, cityVm, cancellation);
                return RedirectToAction(nameof(Index));
            }
        }

        public async Task<ActionResult<CityVm>> Delete(long id, CancellationToken cancellation)
        {
            if (id != 0)
            {
                await cityRepository.DeleteAsync(id, cancellation);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }
        public async Task<ActionResult<CityVm>> Ditelis(int id, CancellationToken cancellation)
        {
          
            return View( );
        }
    }
}
