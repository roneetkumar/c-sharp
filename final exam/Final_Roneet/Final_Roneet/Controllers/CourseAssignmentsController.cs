using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final_Roneet.Model;

namespace Final_Roneet.Controllers
{
    public class CourseAssignmentsController : Controller
    {
        private readonly SMTI_Teacher_Course_FinalContext _context;

        public CourseAssignmentsController(SMTI_Teacher_Course_FinalContext context)
        {
            _context = context;
        }

        // GET: CourseAssignments
        public async Task<IActionResult> Index()
        {
            var sMTI_Teacher_Course_FinalContext = _context.CourseAssignment.Include(c => c.Course).Include(c => c.Teacher);
            return View(await sMTI_Teacher_Course_FinalContext.ToListAsync());
        }

        // GET: CourseAssignments/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseAssignment = await _context.CourseAssignment
                .Include(c => c.Course)
                .Include(c => c.Teacher)
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (courseAssignment == null)
            {
                return NotFound();
            }

            return View(courseAssignment);
        }

        // GET: CourseAssignments/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId");
            ViewData["TeacherId"] = new SelectList(_context.Teachers, "TeacherId", "TeacherId");
            return View();
        }

        // POST: CourseAssignments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseId,TeacherId,AssignmentDate")] CourseAssignment courseAssignment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseAssignment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", courseAssignment.CourseId);
            ViewData["TeacherId"] = new SelectList(_context.Teachers, "TeacherId", "TeacherId", courseAssignment.TeacherId);
            return View(courseAssignment);
        }

        // GET: CourseAssignments/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseAssignment = await _context.CourseAssignment.FindAsync(id);
            if (courseAssignment == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", courseAssignment.CourseId);
            ViewData["TeacherId"] = new SelectList(_context.Teachers, "TeacherId", "TeacherId", courseAssignment.TeacherId);
            return View(courseAssignment);
        }

        // POST: CourseAssignments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CourseId,TeacherId,AssignmentDate")] CourseAssignment courseAssignment)
        {
            if (id != courseAssignment.CourseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseAssignment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseAssignmentExists(courseAssignment.CourseId))
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
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", courseAssignment.CourseId);
            ViewData["TeacherId"] = new SelectList(_context.Teachers, "TeacherId", "TeacherId", courseAssignment.TeacherId);
            return View(courseAssignment);
        }

        // GET: CourseAssignments/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseAssignment = await _context.CourseAssignment
                .Include(c => c.Course)
                .Include(c => c.Teacher)
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (courseAssignment == null)
            {
                return NotFound();
            }

            return View(courseAssignment);
        }

        // POST: CourseAssignments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var courseAssignment = await _context.CourseAssignment.FindAsync(id);
            _context.CourseAssignment.Remove(courseAssignment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseAssignmentExists(string id)
        {
            return _context.CourseAssignment.Any(e => e.CourseId == id);
        }
    }
}
