using Microsoft.AspNetCore.Mvc;
using TrungTamNgoaiNgu.Models;

namespace TrungTamNgoaiNgu.Components
{
    [ViewComponent(Name ="Course")]
    public class CourseComponent :ViewComponent
    {
        private readonly DataContext _context;
        public CourseComponent(DataContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listofCourse= (from c in _context.Courses
                               where (c.IsActive == true) && (c.Status == 1)
                               orderby c.CourseID ascending
                               select c).Take(3).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", listofCourse));
        }
    }
}
