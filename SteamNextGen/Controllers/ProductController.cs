using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SteamNextGen.Data;
using SteamNextGen.Models;
using SteamNextGen.Models.Interface;
using SteamNextGen.Models.Services;
using System.Diagnostics;

namespace SteamNextGen.Controllers
{
    public class ProductController : Controller
    {
        public IProductRepository _productRepository;
        public OrderRepository OrderDetail { get; set; }
        public SteamDBContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;
        private char productName;

        public ProductController(IProductRepository productRepository,SteamDBContext steamDB, UserManager<IdentityUser> userManager)
        {
            this._productRepository = productRepository;
            this._dbContext = steamDB;
            this._userManager = userManager;
        }
        public async Task<IActionResult> Detail(int id)
        {
            // Lấy thông tin sản phẩm đồng bộ
            var product = _productRepository.GetProductDetail(id);
            if (product == null)
            {
                return NotFound();
            }

            // Lấy thông tin người dùng hiện tại
            var user = await _userManager.GetUserAsync(User);
            var email = user?.UserName;

            // Kiểm tra xem sản phẩm đã sở hữu chưa
            var isOwnedQuery = $@"
    SELECT CASE WHEN EXISTS (
        SELECT 1
        FROM OrderDetail OD
        INNER JOIN Orders O ON O.Id = OD.OrderId
        INNER JOIN AspNetUsers ANU ON ANU.UserName = O.Email
        WHERE OD.ProductId = @id AND ANU.UserName = @username
    ) THEN 1 ELSE 0 END AS IsOwned";

            bool isOwned;
            using (var connection = _dbContext.Database.GetDbConnection())
            {
                await connection.OpenAsync();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = isOwnedQuery;
                    command.Parameters.Add(new SqlParameter("@id", id));
                    command.Parameters.Add(new SqlParameter("@username", email));

                    var result = await command.ExecuteScalarAsync();
                    isOwned = Convert.ToInt32(result) == 1;
                }
            }

            // Tạo ViewModel
            var viewModel = new ProductDetailViewModel
            {
                Product = product,
                IsOwned = isOwned
            };

            return View(viewModel);
        }


        public IActionResult Shop()
        {
            return View(_productRepository.GetTrendingProducts());
        }
        public IActionResult ShopAll()
        {
            return View(_productRepository.GetAllProducts());
        }
        public IActionResult TopPlay()
        {
            return View(_productRepository.GetTopPlayProducts());
        }
        public IActionResult TopSale()
        {
            return View(_productRepository.GetTopSaleProducts());
        }
        public IActionResult P2P()
        {
            return View(_productRepository.GetSellProducts());
        }
        public IActionResult F2P()
        {
            return View(_productRepository.GetFreeProducts());
        }
        public IActionResult Search(string productname)
        {
            var search = _productRepository.SearchProductByName(productname);
            if (search != null)
            {
                return View("Search", search);
            }
            else return View("Shop");  
        }

    }
}
