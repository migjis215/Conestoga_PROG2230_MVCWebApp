/* CompaniesController.cs
 * Class that stores companies data in models and passes the models to the appropriate views
 * Revision History
 *      Jisung Kim, 2021.10.14: Created
 *      
 */

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROG2230_JisungKim.Models;

namespace PROG2230_JisungKim.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly TransactionRecordContext _context;

        public CompaniesController(TransactionRecordContext context)
        {
            _context = context;
        }

        // GET: Companies
        public async Task<IActionResult> Index()
        {
            var companyContext = _context.Companies.OrderBy(m => m.Name);
            return View(await companyContext.ToListAsync());
        }

        // GET: Companies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // GET: Companies/Create
        public IActionResult Add()
        {
            return View();
        }

        // POST: Companies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("CompanyId,Name,Address,TickerSymbol")] Company company)
        {
            if (ModelState.IsValid)
            {
                company.TickerSymbol = company.TickerSymbol.ToString().ToUpper();
                _context.Add(company);
                await _context.SaveChangesAsync();
                TempData["message"] = "<br /><span class='alert alert-success'>" + company.Name + " has been added</span><br /><br />";
                return RedirectToAction(nameof(Index));
            }
            return View(company);
        }

        // GET: Companies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }

        // POST: Companies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompanyId,Name,Address,TickerSymbol")] Company company)
        {
            if (id != company.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(company);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyExists(company.CompanyId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                TempData["message"] = "<br /><span class='alert alert-success'>Save Successful</span><br /><br />";
                return RedirectToAction(nameof(Index));
            }
            return View(company);
        }

        // GET: Companies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Companies
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (company == null)
            {
                return NotFound();
            }

            return View(company);
        }

        // POST: Companies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var company = await _context.Companies.FindAsync(id);
            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();
            TempData["message"] = "<br /><span class='alert alert-danger'>" + company.Name + " has been deleted</span><br /><br />";
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyExists(int id)
        {
            return _context.Companies.Any(e => e.CompanyId == id);
        }
    }
}
