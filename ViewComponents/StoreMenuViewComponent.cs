using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicStore.Models;
using System.Threading.Tasks;

namespace MusicStore.ViewComponents
{
    public class StoreMenuViewComponent : ViewComponent
    {
        private readonly MyContext _myContext;

        public StoreMenuViewComponent(MyContext myContext)
        {
            _myContext = myContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var genres = await _myContext.Genres.ToListAsync();
            return View(genres);
        }
        
    }
}
