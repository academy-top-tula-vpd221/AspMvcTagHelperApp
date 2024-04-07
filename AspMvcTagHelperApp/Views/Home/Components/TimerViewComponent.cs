using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace AspMvcTagHelperApp.Views.Home.Components
{
    public class TimerViewComponent
    {
        public string Invoke()
        {
            return $"Current time: {DateTime.Now.ToShortTimeString()}";
        }
    }

    public class Dater : ViewComponent
    {
        public string Invoke()
        {
            return $"Current date: {DateTime.Now.ToShortDateString()}";
        }
    }

    [ViewComponent]
    public class DateTimer
    {
        public string Invoke()
        {
            return $"Current date and time: {DateTime.Now.ToString()}";
        }
    }

    public class ViewTimer : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //var str = $"Current time: {DateTime.Now.ToShortTimeString()}";
            //return Content(str);

            HtmlString strHtml = new($"<b>Current time:</b> <i>{DateTime.Now.ToShortTimeString()}</i>");

            //return new ContentViewComponentResult(str);
            return new HtmlContentViewComponentResult(strHtml);
        }
    }

}
