﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
        private char productName;

        public ProductController(IProductRepository productRepository,SteamDBContext steamDB)
        {
            this._productRepository = productRepository;
            this._dbContext = steamDB;
        }
        public IActionResult Detail(int id)
        {
            var product = _productRepository.GetProductDetail(id);
            if (product != null)
            {
                return View(product);
            }
            return NotFound();
        }
        public IActionResult _Detail(int id)
        {
            var product = _productRepository.GetProductDetail(id);
            if (product != null)
            {
                return View(product);
            }
            return NotFound();
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
