using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;

namespace MyPortolioUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavBarComponentPartial : ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();	
	  public IViewComponentResult Invoke()
		{ 
			ViewBag.ToDoListCount=context.ToDoLists.Where(x => x.Status == false).Count();
			var values = context.ToDoLists.Where(x =>  x.Status == false).ToList();	
			return View(values);
		}	
	}
}
