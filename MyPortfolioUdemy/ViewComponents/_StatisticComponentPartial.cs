using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.SkillCount = context.Skills.Count();
            ViewBag.ExperienceCount = context.Experiences.Count();
            ViewBag.PortfolioCount = context.Portfolios.Count();
            ViewBag.skillValueAvg = Convert.ToUInt32(context.Skills.Average(s => s.Value));


            return View();
        }
    }
}
