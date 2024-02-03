using Microsoft.AspNetCore.Mvc;
using steam.Models;
using steam.Models.Interface;

namespace steam.Controllers
{
    public class ContactController : Controller
    {
        private IContactRepository _contactRepository;
        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            _contactRepository.Send(contact);
            return View();
        }
        public IActionResult ContactComplete()
        {
            return View();
        }
    }
}
