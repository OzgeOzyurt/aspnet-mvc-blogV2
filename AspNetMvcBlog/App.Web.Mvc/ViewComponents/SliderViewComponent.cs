using Microsoft.AspNetCore.Mvc;
using App.Persistence.Models;
using App.Persistence.Data;

namespace App.Web.Mvc.ViewComponents
{
	public class SliderViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var database = new DataBase();
			var sliderItem = database.SliderItems;
			return View(sliderItem);

		}
	}
}