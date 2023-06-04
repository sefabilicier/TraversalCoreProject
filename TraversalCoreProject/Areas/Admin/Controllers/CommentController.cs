using BusinessLayer.Abstracts;
using BusinessLayer.Concretes;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Member")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService; //hata verir ama startup da tanımlamam lazım

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values = _commentService.TGetListCommentWithDestination();
            return View(values);
        }


        public IActionResult DeleteComment(int id)
        {
            var values = _commentService.TGetById(id);
            _commentService.TRemove(values);
            return RedirectToAction("Index");
        }
    }
}
