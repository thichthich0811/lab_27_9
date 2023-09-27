using lab_20_9.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace lab_20_9.ViewComponents
{
    public class RenderViewComponent:ViewComponent
    {
        private List<MenuItem> MenuItems=new List<MenuItem>();  
        public RenderViewComponent()
        {
            MenuItems = new List<MenuItem>()
            {
                new MenuItem() { Id = 1, Name = "Branches", Link = "Branches/List" },
                new MenuItem() { Id = 2, Name = "Students", Link = "Students/List" },
                new MenuItem() { Id = 3, Name = "Subjects", Link = "Subjects/List" },
                new MenuItem() { Id = 4, Name = "Courses", Link = "Courses/List" }
            };
        }
        //xử lí dữ liệu để trình bày lên view
        //truyền thông không đồng bộ
        public async Task<ViewViewComponentResult> InvokeAsync()
        {
            return View("RenderLeftMenu", MenuItems);
        }
        //truyền thông đồng bộ
        //public IViewComponentResult Invoke()
        //{
        //   return
        //}
    }
}
