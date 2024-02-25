using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using SteamNextGen.Data;
using SteamNextGen.Models;

namespace SteamNextGen.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public SteamDBContext _dbContext {  get; set; }   
        private readonly UserManager<IdentityUser> _userManager;

        public AccountController(UserManager<IdentityUser> userManager, SteamDBContext steamDB)
        {
            _userManager = userManager;
            _dbContext = steamDB;
        }
        public async Task<IActionResult> Library()
        {
            var user = await _userManager.GetUserAsync(User);
            var email = user.UserName;
            string productQuery = $@"
        SELECT DISTINCT P.*
        FROM OrderDetail OD
        INNER JOIN Product P ON OD.ProductId = P.Id
        INNER JOIN Orders O ON O.Id = OD.OrderId
        INNER JOIN AspNetUsers ANU ON ANU.UserName = O.Email
        WHERE ANU.UserName = '{email}'";
            var products = _dbContext.Product.FromSqlRaw(productQuery).ToList();
            return View(products);
        }
        
        public async Task<IActionResult> DelItem(Product prod   )
        {
            var user = await _userManager.GetUserAsync(User);
            var email = user.UserName;
            var ItemId = _dbContext.orderDetail.FirstOrDefault(s =>s.Product.Id == prod.Id && s.Order.Email == email);
            _dbContext.orderDetail.RemoveRange(ItemId);
            _dbContext.SaveChanges();
            return RedirectToAction("Library");
        }

    }
}
