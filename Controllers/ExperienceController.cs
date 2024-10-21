using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;
using MyPortolioUdemy.DAL.Entities;

namespace MyPortolioUdemy.Controllers
{
	public class ExperienceController : Controller
	{
		MyPortfolioContext Context = new MyPortfolioContext();
		public IActionResult ExperienceList()
		{
			var values = Context.Experiences.ToList();
			return View(values);
		}


		[HttpGet]
		public IActionResult CreateExperience()
		{
			return View();	
		}

		[HttpPost]
		public IActionResult CreateExperience(Experience ecperience)
		{
			Context.Experiences.Add(ecperience);
			Context.SaveChanges();
			return RedirectToAction("ExperienceList");	
		}

		public IActionResult DeleteExperience(int id)
		{ 
			var value = Context.Experiences.Find(id);
			Context.Experiences.Remove(value);
			Context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}

		[HttpGet]

		public IActionResult UpdateExperience(int id) 
		{
			var value = Context.Experiences.Find(id);
			return View(value);
		}

		[HttpPost]	
		
		public IActionResult UpdateExperience(Experience ecperience)
		{
			Context.Experiences.Update(ecperience);
			Context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}


	}
}
