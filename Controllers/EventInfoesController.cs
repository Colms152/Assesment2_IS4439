using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eventchain.Data;
using Eventchain.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Eventchain.Controllers
{
    [Authorize]
    public class EventInfoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventInfoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EventInfoes
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // UserId currently logged in


            var applicationDbContext = _context.EventInfo.Where(s => s.Parent.UserId == userId).Include(e => e.Parent);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: EventInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventInfo = await _context.EventInfo
                .Include(e => e.Parent)
                .FirstOrDefaultAsync(m => m.EventInfoId == id);
            if (eventInfo == null)
            {
                return NotFound();
            }

            return View(eventInfo);
        }

        // GET: EventInfoes/Create
        public IActionResult Create()
        {
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId");
            return View();
        }

        // POST: EventInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EventInfoId,Genre,Recurring,EventId")] EventInfo eventInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eventInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", eventInfo.EventId);
            return View(eventInfo);
        }

        // GET: EventInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventInfo = await _context.EventInfo.FindAsync(id);
            if (eventInfo == null)
            {
                return NotFound();
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", eventInfo.EventId);
            return View(eventInfo);
        }

        // POST: EventInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EventInfoId,Genre,Recurring,EventId")] EventInfo eventInfo)
        {
            if (id != eventInfo.EventInfoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eventInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventInfoExists(eventInfo.EventInfoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Events, "EventId", "EventId", eventInfo.EventId);
            return View(eventInfo);
        }

        // GET: EventInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventInfo = await _context.EventInfo
                .Include(e => e.Parent)
                .FirstOrDefaultAsync(m => m.EventInfoId == id);
            if (eventInfo == null)
            {
                return NotFound();
            }

            return View(eventInfo);
        }

        // POST: EventInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eventInfo = await _context.EventInfo.FindAsync(id);
            _context.EventInfo.Remove(eventInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventInfoExists(int id)
        {
            return _context.EventInfo.Any(e => e.EventInfoId == id);
        }
    }
}
