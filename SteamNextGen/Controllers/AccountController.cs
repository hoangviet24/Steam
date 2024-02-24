using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SteamNextGen.Data;

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
            string userId = user?.Id; // Lấy ID người dùng

            // Sử dụng userId để truy xuất dữ liệu...
            string productQuery = $@"
            select distinct P.*
from orderDetail OD, Product P, orders Os, AspNetUsers ANU
where OD.ProductId=p.Id and Os.Id = OD.OrderId  and ANU.Id = '{userId}'";
            var products = _dbContext.Product.FromSqlRaw(productQuery).ToList();
            return View(products);
        }
    }
}
