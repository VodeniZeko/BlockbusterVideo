using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movies.Data;
using movies.Models;

namespace movies.Controllers
{
    public class CustomersController : Controller
    {
        private readonly BlockbusterContext _dbContext;


        public CustomersController(BlockbusterContext DbContext)
        {
            _dbContext = DbContext;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
            base.Dispose(disposing);
        }

        //Customer
        public IActionResult Index()
        {

            var customersData = _dbContext.Customers.Include(c => c.MembershipType).ToList();
            var customersModel = customersData.Select(c => new Models.Customer
            {
                Id = c.Id,
                Name = c.Name,
                MembershipType = new Models.MembershipType 
                {
                    Id = c.MembershipType.Id,
                    DiscountRate = c.MembershipType.DiscountRate
                }
            });

            return View(customersModel.ToList());
        }
        //Customer/Details
        public IActionResult Details(int Id)
        {
            var customer = _dbContext.Customers.SingleOrDefault(c => c.Id == Id);

            if (customer == null) return NotFound();

            return View(customer);
        }
    }
}
