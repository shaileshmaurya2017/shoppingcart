using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Data;
using ShoppingCart.Model.DB;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private IWebHostEnvironment _hostingEnvironment;
        public UploadController(ApplicationDbContext context, IWebHostEnvironment environment)
        
        {
           
                _hostingEnvironment = environment;
                _context = context;
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> PostUpdate(int id, IFormFile pfile)
        {

            var product = _context.Find<Product>(id);
            if (product == null)
            {
                return BadRequest();
            }

            string uploads = Path.Combine(@"C:\Users\shailesh\source\repos\ShoppingcartFrontEnd\shoppingcart1.0\shoppingcart\src\assets\", "uploads");

            if (pfile.Length > 0)
            {
                var filename = new Guid();
                
                string filePath = Path.Combine(uploads, pfile.FileName);
                using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await pfile.CopyToAsync(fileStream);
                }
            }
            product.filename = pfile.FileName;


           await _context.SaveChangesAsync();

           

            return NoContent();
        }


    }
}
