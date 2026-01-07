using Repository_Pattern_Assignment_JAN_06.Models;
using Repository_Pattern_Assignment_JAN_06.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Repository_Pattern_Assignment_JAN_06.Controllers
{
    public class ContactController : Controller
    {
        IContactRepository _contactRepository = null;

        public ContactController()
        {
            _contactRepository = new ContactRepository();
        }

        // Index
        public async Task<ActionResult> Index()
        {
            var contacts = await _contactRepository.GetAllAsync();
            return View(contacts);
        }

        // Creating
        public ActionResult Create()
        {
            return View();
        }

        // Creating
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                await _contactRepository.CreateAsync(contact);
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        // Deleting
        public async Task<ActionResult> Delete(long id)
        {
            await _contactRepository.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}