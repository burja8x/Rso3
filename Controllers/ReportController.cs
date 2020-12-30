using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rso3.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ReportController : Controller
    {
        private readonly Settings _settings;
        public ReportController(IOptionsSnapshot<Settings> settings)
        {
            _settings = settings.Value;
        }


        // GET: ReportController
        public ActionResult<IEnumerable<string>> Index()
        {
            //return new string[] { "Test", "Hd" };
            return View();
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Test", _settings.Message };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        { 
            if (Microsoft.Extensions.Diagnostics.HealthChecks.RandomHealthCheck.healthy) {
                Microsoft.Extensions.Diagnostics.HealthChecks.RandomHealthCheck.healthy = false;
            }
            else {
                Microsoft.Extensions.Diagnostics.HealthChecks.RandomHealthCheck.healthy = true;
            }

            return $"RandomHealthCheck .... healthy = {Microsoft.Extensions.Diagnostics.HealthChecks.RandomHealthCheck.healthy}";
        }


        // GET: ReportController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReportController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReportController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReportController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReportController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReportController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReportController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
