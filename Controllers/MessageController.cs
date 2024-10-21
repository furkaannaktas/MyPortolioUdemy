using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;

namespace MyPortolioUdemy.Controllers
{
    public class MessageController : Controller
    {
		MyPortfolioContext Context = new MyPortfolioContext();
		public IActionResult Inbox()
        {
			var values = Context.Messages.ToList();
			return View(values);
        }

        public IActionResult ChangeIsReadToTrue(int id)
        {
            var value = Context.Messages.Find(id);
            value.IsRead = true;
            Context.SaveChanges();
            return RedirectToAction("Inbox");
        }


		public IActionResult ChangeIsReadToFalse(int id)
		{
			var value = Context.Messages.Find(id);
			value.IsRead = false;
			Context.SaveChanges();
			return RedirectToAction("Inbox");
		}

		public IActionResult DeleteMessage(int id)
		{
			var value = Context.Messages.Find(id);
			Context.Messages.Remove(value);
			Context.SaveChanges();
			return RedirectToAction("Inbox");
		}

		public IActionResult MessageDetail(int id)
		{
			var value = Context.Messages.Find(id);
			return View(value);
		}

	}
}
