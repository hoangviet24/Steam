using Microsoft.AspNetCore.Mvc;
using SteamNextGen.Models;
using SteamNextGen.Models.Interface;
using System.Net.Mail;
using System.Net;

namespace SteamNextGen.Controllers
{
    public class ContactController : Controller
    {
        private IContactRepository _ContactRepository { get; set; }

        public ContactController(IContactRepository contactRepository)
        {
            this._ContactRepository = contactRepository;
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            _ContactRepository.Send(contact);
            return View(contact);
        }
        public IActionResult ContactComplete()
        {
            return View();
        }
    }
}
