using AspMvcTagHelperApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspMvcTagHelperApp.Views.Home.Components
{
    public class ListViewComponent : ViewComponent
    {
        IEnumerable<string> list;
        PageModel pageModel;

        public ListViewComponent(IEnumerable<string> list)
        {
            this.list = list;
        }

        //public IViewComponentResult Invoke(IEnumerable<string> list) => View("ListView", list);
        public IViewComponentResult Invoke(PageModel pageModel) => View("ListView", pageModel);

    }
}
