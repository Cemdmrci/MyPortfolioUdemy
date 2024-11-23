using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortolioUdemy.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
			ViewBag.v1 = context.Skills.Count(); /*Skills tablosundaki toplam kayıt(yetenek) sayısını hesaplar ve ViewBag.YetenekSayisi değişkenine atar.*/
            ViewBag.v2 = context.Messages.Count();
			ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();
			ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.v5 = context.Skills.Average(x => x.Value);
            ViewBag.v6 = context.Experiences.Count();
            ViewBag.v7 = context.Portfolios.Count();
            ViewBag.v8 = (from s in context.Skills
                                       orderby s.Value descending
                                       select s.Title).FirstOrDefault();
            ViewBag.v9= (from s in context.Skills
                                      orderby s.Value ascending
                                      select s.Title).FirstOrDefault();
            return View();
		}
	}
}
