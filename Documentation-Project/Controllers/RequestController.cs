using Evo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;

namespace DocumentationProject.Controllers
{
    public class RequestController : Controller
    {
        private readonly MyDbContext _context;
        private readonly ILogger<RequestController> _logger;

        public RequestController(MyDbContext context, ILogger<RequestController> logger)
        {
            _context = context;
            _logger = logger;
        }


        public async Task<IActionResult> Request()
        {
            //var requests = _context.Requests
            //    .Select(r => new Request
            //    {
            //        Id = r.Id,
            //        Category = r.Category ?? string.Empty,
            //        Method = r.Method ?? string.Empty,
            //        Description = r.Description ?? string.Empty,
            //        Url = r.Url ?? string.Empty,
            //        json = r.json,
            //        p_response = r.p_response ?? string.Empty,
            //        n_response = r.n_response ?? string.Empty,
            //        p_response_code = r.p_response_code ?? string.Empty,
            //        n_response_code = r.n_response_code ?? string.Empty
            //    })
            //    .ToList();

            //return View(requests);

           var requests = _context.Requests.ToList(); 

            if (requests == null)
            {
                // Hata mesajı veya loglama yapabilirsiniz
                return Content("Veritabanından veri alınamadı.");
            }

            if (!requests.Any())
            {
                // Veritabanında veri bulunmadığını belirtebilirsiniz
                return Content("Veritabanında veri bulunmuyor.");
            }

            return View(requests);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
            
          
        }
    }

