using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.Image = portfolioContext.Features.Select(x => x.ImageUrl).FirstOrDefault();
            var values = portfolioContext.Features.ToList();
            return View(values); ;
        }
    }
}
