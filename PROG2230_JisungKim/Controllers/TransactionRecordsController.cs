/* TransactionType.cs
 * Class that stores transaction records data in models and passes the models to the appropriate views
 * Revision History
 *      Jisung Kim, 2021.09.28: Created
 *      Jisung Kim, 2021.10.14: Edited
 *      
 */

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROG2230_JisungKim.Models;

namespace PROG2230_JisungKim.Controllers
{
    public class TransactionRecordsController : Controller
    {
        private readonly TransactionRecordContext _context;

        public TransactionRecordsController(TransactionRecordContext context)
        {
            _context = context;
        }

        // GET: TransactionRecords
        public async Task<IActionResult> Index(string order)
        {
            var transactionRecordContext = _context.TransactionRecords.Include(m => m.TransactionType).Include(m => m.Company).OrderBy(m => m.Company.Name);
            ViewBag.order = "DESC";


            if (order == "DESC")
            {
                transactionRecordContext = _context.TransactionRecords.Include(m => m.TransactionType).Include(m => m.Company).OrderByDescending(m => m.Company.Name);
                ViewBag.order = "ASC";
            }

            return View(await transactionRecordContext.ToListAsync());
        }

        // GET: TransactionRecords/Add
        public IActionResult Add()
        {
            ViewBag.Company = new SelectList(_context.Companies, "CompanyId", "Name");
            ViewBag.TransactionType = new SelectList(_context.TransactionTypes, "TransactionTypeId", "Name");
            return View();
        }

        // POST: TransactionRecords/Add
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("TransactionRecordId,Quantity,SharePrice,TransactionTypeId,CompanyId")] TransactionRecord transactionRecord)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transactionRecord);
                await _context.SaveChangesAsync();
                TempData["message"] = "<br /><span class='alert alert-success'>Add Successful</span><br /><br />";
                return RedirectToAction(nameof(Index));
            }
            return View(transactionRecord);
        }

        // GET: Companies/Transactions/5
        public async Task<IActionResult> Transactions(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionRecord = await _context.TransactionRecords.Include(m => m.TransactionType).Include(m => m.Company).FirstOrDefaultAsync(m => m.CompanyId == id);
            var companyName = (await _context.Companies.FirstOrDefaultAsync(m => m.CompanyId == id)).Name;
            if (transactionRecord == null)
            {
                TempData["message"] = "<br /><span class='alert alert-danger'>There is no transaction record for " + companyName + "</span><br /><br />";
                return RedirectToAction("Index", "Companies");
            }

            return View(transactionRecord);
        }

        // GET: TransactionRecords/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionRecord = await _context.TransactionRecords.FindAsync(id);
            if (transactionRecord == null)
            {
                return NotFound();
            }
            ViewBag.Company = new SelectList(_context.Companies, "CompanyId", "Name", transactionRecord.TransactionTypeId);
            ViewBag.TransactionType = new SelectList(_context.TransactionTypes, "TransactionTypeId", "Name", transactionRecord.TransactionTypeId);
            return View(transactionRecord);
        }

        // POST: TransactionRecords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransactionRecordId,Quantity,SharePrice,TransactionTypeId,CompanyId")] TransactionRecord transactionRecord)
        {
            if (id != transactionRecord.TransactionRecordId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transactionRecord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionRecordExists(transactionRecord.TransactionRecordId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                TempData["message"] = "<br /><span class='alert alert-success'>Save Successful</span><br /><br />";
                return RedirectToAction("Transactions", new { id = transactionRecord.CompanyId });
            }
            ViewBag.Company = new SelectList(_context.Companies, "Name", "Name", transactionRecord.TransactionTypeId);
            ViewBag.TransactionTypeName = new SelectList(_context.TransactionTypes, "Name", "Name", transactionRecord.TransactionTypeId);
            return View(transactionRecord);
        }

        // GET: TransactionRecords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionRecord = await _context.TransactionRecords.Include(m => m.TransactionType).Include(m => m.Company)
                .FirstOrDefaultAsync(m => m.TransactionRecordId == id);
            if (transactionRecord == null)
            {
                return NotFound();
            }

            return View(transactionRecord);
        }

        // GET: TransactionRecords/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionRecord = await _context.TransactionRecords.Include(m => m.Company)
                .FirstOrDefaultAsync(m => m.TransactionRecordId == id);
            if (transactionRecord == null)
            {
                return NotFound();
            }

            return View(transactionRecord);
        }

        // POST: TransactionRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transactionRecord = await _context.TransactionRecords.Include(m => m.Company).FirstOrDefaultAsync(m => m.TransactionRecordId == id);
            _context.TransactionRecords.Remove(transactionRecord);
            await _context.SaveChangesAsync();

            TempData["message"] = "<br /><span class='alert alert-danger'>The transaction of " + transactionRecord.Company.Name + " has been deleted</span><br /><br />";
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionRecordExists(int id)
        {
            return _context.TransactionRecords.Any(e => e.TransactionRecordId == id);
        }
    }
}
