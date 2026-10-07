using AcxiomCRM.Data; using Microsoft.AspNetCore.Mvc; using Microsoft.EntityFrameworkCore;
namespace AcxiomCRM.Controllers;
public class HomeController:Controller { private readonly ApplicationDbContext _db; public HomeController(ApplicationDbContext db)=>_db=db; public async Task<IActionResult> Index(){ ViewBag.Customers=await _db.Customers.CountAsync(); ViewBag.Leads=await _db.Leads.CountAsync(); ViewBag.Opportunities=await _db.Opportunities.CountAsync(x=>x.Status=="Open"); ViewBag.Pipeline=await _db.Opportunities.Where(x=>x.Status=="Open").SumAsync(x=>(double?
)x.Amount)??0; return View(); } }
