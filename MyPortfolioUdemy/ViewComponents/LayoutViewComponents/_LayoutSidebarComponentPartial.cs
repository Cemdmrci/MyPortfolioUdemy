using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarComponentPartial : ViewComponent
	{
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.Image = context.Features.Select(x => x.ImageUrl).FirstOrDefault();
            return View();
        }
    }
}
