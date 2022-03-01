using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishListApp.Models;
using WishListApp.Services;

namespace WishListApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IEnumerable<WishItem> listOfWishes { get; set; }
        
        [BindProperty]
        public WishItem WhishItemEdit { get; set; }
        
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            listOfWishes =  _db.WishListDb;

            foreach (var item in listOfWishes)
            {
                item.StatusMessage = item.IsAcquired == true ? "Reserved" : "Gift";
                
            }
            WhishItemEdit = _db.WishListDb.Find(id);
        }
        
        public IActionResult OnPostUpdate()
        {
            WishItem whishItem = _db.WishListDb.Find(WhishItemEdit.Id);
            if (whishItem != null)
            {
                
                whishItem.IsAcquired = whishItem.IsAcquired == true ? false : true;
              
                _db.SaveChanges();

               return RedirectToPage("Index");

            }
            return NotFound();
        }
        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{


        //    _logger = logger;
        //}


    }
}
