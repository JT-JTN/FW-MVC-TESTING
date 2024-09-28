using Microsoft.AspNetCore.Mvc;
using UseCase.Plugins;

namespace FW.WebApp.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IClientRepository _clientRepository;
        public ClientsController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<IActionResult> Index()
        {
            var clients = await _clientRepository.GetAllClientsAsync();

            return View(clients);
        }

        public async Task<IActionResult> Details(int id)
        {
            if (id <= 0)
                return BadRequest("Route Parameter Not Found");

            var client = await _clientRepository.GetClientByIdWithDetailsAsync(id);

            return View(client);
        }
    }
}
