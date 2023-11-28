using KitXIXTask.Models;
using KitXIXTask.Models.Viewmodels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KitXIXTask.Controllers
{

    public class ProductController : Controller
    {
        private readonly DataDbContext _dbContext;

        public ProductController()
        {
            _dbContext = new DataDbContext();
        }

        // GET: Product
        public ActionResult Index()
        {
            var allProducts = _dbContext.tbl_Products.ToList();

            
            var searchViewModel = new SearchViewModel
            {
                SearchResults = allProducts
            };

            return View(searchViewModel);
        }

        [HttpGet]
        public ActionResult Search(SearchViewModel searchModel)
        {
            var searchResults = ExecuteSearchQuery(searchModel);

            var searchViewModel = new SearchViewModel
            {
                ProductName = searchModel.ProductName,
                Size = searchModel.Size,
                Price = searchModel.Price,
                MfgDate = searchModel.MfgDate,
                Category = searchModel.Category,
                Condition = searchModel.Condition,
                SearchResults = searchResults
            };

            return View(searchViewModel);
        }

        private List<tbl_Product> ExecuteSearchQuery(SearchViewModel searchModel)
        {
            var parameters = new List<SqlParameter>
        {
            new SqlParameter("@ProductName", searchModel.ProductName ?? (object)DBNull.Value),
            new SqlParameter("@Size", searchModel.Size ?? (object)DBNull.Value),
            new SqlParameter("@Price", searchModel.Price ?? (object)DBNull.Value),
            new SqlParameter("@MfgDate", searchModel.MfgDate ?? (object)DBNull.Value),
            new SqlParameter("@Category", searchModel.Category ?? (object)DBNull.Value),
            new SqlParameter("@Condition", searchModel.Condition)
        };

            var searchResults = _dbContext.Database.SqlQuery<tbl_Product>("EXEC SearchProducts @ProductName, @Size, @Price, @MfgDate, @Category, @Condition", parameters.ToArray()).ToList();

            return searchResults;
        }
    }

}