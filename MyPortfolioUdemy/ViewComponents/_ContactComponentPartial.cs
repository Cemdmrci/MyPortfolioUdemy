using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
	public class _ContactComponentPartial : ViewComponent
	{
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.Title = context.Contacts.Select(x => x.Title).FirstOrDefault();
            ViewBag.Description = context.Contacts.Select(x => x.Description).FirstOrDefault();

            var values = context.Contacts.ToList();
            return View(values);
        }
    }
}
