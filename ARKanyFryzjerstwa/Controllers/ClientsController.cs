using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.Services;
using ARKanyFryzjerstwa.Services.IServices;
using ARKanyFryzjerstwa.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ARKanyFryzjerstwa.Controllers
{
    [Authorize]
    public class ClientsController : BaseController
    {
        private readonly IClientsService _clientsService;

        public ClientsController(IdentityContext identityContext, IHttpContextAccessor httpContextAccessor, 
            UserManager<User> userManager, IClientsService? clientsService = null)
             : base(userManager, httpContextAccessor)
        {
            _clientsService = clientsService ?? new ClientsService(identityContext, UserSalonId);
        }

        /// <summary>
        /// Obsługuje żądanie GET: /Clients
        /// </summary>
        /// <returns> Obiekt <see cref="ViewResult"/> strony z listą klientów salonu. </returns>
        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            var model = _clientsService.GetClientsModel(CurrentSalonId);
            return View(model);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Clients/AddNewClient
        /// </summary>
        /// <param name="client"> Klient do dodania. </param>
        /// <returns> Obiekt <see cref="ClientModel"/> w formacie JSON z danymi utworzonego klienta. </returns>
        [Authorize]
        [HttpPost]
        public JsonResult AddNewClient(Client client)
        {
            _clientsService.CreateClient(client);
            var result = _clientsService.ConvertClient(client);
            return Json(result);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Clients/UpdateClient
        /// </summary>
        /// <param name="client"> Klient do zauktualizowania.</param>
        /// <returns> Obiekt <see cref="ClientModel"/> w formacie JSON z danymi zaktualizowanego klienta. </returns>
        [Authorize]
        [HttpPost]
        public JsonResult UpdateClient(ClientModel client)
        {
            var result = _clientsService.UpdateClient(client);
            return Json(result);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Clients/DuplicateClientVerification
        /// </summary>
        /// <param name="client"> Klient do weryfikacji duplikatu.</param>
        /// <returns> Obiekt <see cref="bool"/> w formacie JSON informujący czy klient ma duplikat. </returns>
        [Authorize]
        [HttpPost]
        public JsonResult DuplicateClientVerification(ClientModel client)
        {
            var result = _clientsService.IsClientDuplicate(client);
            return Json(result);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Clients/RemoveClient
        /// </summary>
        /// <param name="clientId"> Unikalny identyfikator klienta. </param>
        [Authorize]
        [HttpPost]
        public void RemoveClient(int clientId)
        {
            _clientsService.RemoveClient(clientId);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Clients/RemoveClients
        /// </summary>
        /// <param name="clientsIds"> Unikalny identyfikator klienta. </param>
        [Authorize]
        [HttpPost]
        public void RemoveClients(List<int> clientsIds)
        {
            _clientsService.RemoveClients(clientsIds);
        }
    }
}
