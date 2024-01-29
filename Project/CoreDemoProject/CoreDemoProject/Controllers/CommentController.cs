using BusinessLayer.Conctrets;
using DataAccessLayer.MyEntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemoProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var values = commentManager.GetAll(id);
            
            return PartialView("CommentListByBlog", values);
        }
    }
}
