using BookShareMVC.Context;
using BookShareMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookShareMVC.Controllers
{
    public class LoanController : Controller
    {
        private readonly AppDbContext _context;

        public LoanController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<LoanModel> loans = _context.Loans;

            return View(loans);
        }
    }
}
