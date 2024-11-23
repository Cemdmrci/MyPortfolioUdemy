using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class SocialMediaController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult SocialMediaList()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSocialMedia(SocialMedia socialmedia)
        {
            context.SocialMedias.Add(socialmedia);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var values = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(values);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var values = context.SocialMedias.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialmedia)
        {
            context.SocialMedias.Update(socialmedia);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
    }
}
