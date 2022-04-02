using LOGIC.Services.Interfaces;
using DAL.Model;
using DAL.Model.LoginModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;
using DAL.Model.ViewModel;

namespace BlogCoreAPI.Controllers
{
    [ApiController]
    [EnableCors("MyPolicy")]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private IPostService _IpostService;
        private IAccountService _IaccountService;
        private IUserSevice _IuserService;
        private IPostCommentService _IpostCommentService;
        public AccountController(ILogger<AccountController> logger,IPostCommentService postCommentService,IUserSevice userSevice, IPostService postService, IAccountService accountService)
        {
            _logger = logger;
            this._IpostService = postService;
            this._IaccountService = accountService;
            this._IuserService = userSevice;
            this._IpostCommentService = postCommentService;
        }

        [HttpPost("RegisterUser")]
        public IActionResult RegisterUser(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            else
            {
                user.Role = "user";
                user.Registered = DateTime.Now;
                user.LastLogin = DateTime.Now;
                _IuserService.AddNewUser(user);
                _IuserService.Save();
                return CreatedAtAction(nameof(GetInfoAccount), new { id = user.UserID }, user);
                /*return NoContent();*/
            }
        }
        /*        [Authorize]*/
        [HttpPost("GetInfoAccount")]
        public IEnumerable<User> GetInfoAccount([FromBody]User user)
        {
            /*emailAccount = "laanhkhoa800@gmail.com";*/
            var info = _IaccountService.GetUserByEmail(user.Email);
            if (info != null)
            {
                yield return info;
            }
        }
        /*public async Task<ActionResult<User>> GetInfoAccount()
        {
            var info = _IaccountService.GetUserByEmail(User.Identity.Name);
            if(info == null)
            {
                return BadRequest();
            }
            else
            {
                return info;
            }
        }*/

        [Authorize]
        [HttpGet("GetMyPost")]
        public IEnumerable<Post> GetMyPost()
        {
            int AccountID = _IaccountService.GetUserByEmail(User.Identity.Name).UserID;
            var posts = _IpostService.GetPostOfUserID(AccountID);
            foreach (var post in posts)
            {

                    yield return post;

            }
        }
        [HttpPost("CreateMyPost")]
        public ActionResult CreateMyPost([FromBody]Post post)
        {
            if (post == null)
            {
                return BadRequest();
            }
            else
            {
                post.CreateAT = DateTime.Now;
                post.UpdateAT = DateTime.Now;
                post.PublishedAT = DateTime.Now;
                //post.authorID = _IaccountService.GetUserByEmail(User.Identity.Name).userID;
                _IpostService.AddNewPost(post);
                _IpostService.Save();
                //GetMyPost error, fix GetMyPost fn open it
                //return CreatedAtAction(nameof(GetMyPost), new { id = post.postID }, post);
                return NoContent();
            }
        }
        [HttpGet("Login")]
        [AllowAnonymous]
        public async Task<ActionResult> Login(string returnUrl = null)
        {
            await _IaccountService.Logout(HttpContext);
            await _IaccountService.Logout(HttpContext);
            return NoContent();
        }

        [HttpPost("LoginAccout")]
        public async Task<ActionResult> Login([FromBody] LoginModel model)
        {
            var result = await _IaccountService.Login(model, HttpContext);
            if (result == null)
            {
                return NotFound();
            }
            /*     return LocalRedirect(result);*/
            Response.StatusCode = 200;
            return NoContent();
        }
        /// <summary>
        /// Logout account  
        /// </summary>
        /// <returns></returns>
        [HttpPost("Logout")]
        public ActionResult LogOut()
        {
            if (User.Identity.Name == null)
            {
                return BadRequest();
            }
            else
            {
                _ = _IaccountService.Logout(HttpContext);
                Response.StatusCode = 204;
                return NoContent();
            }
        }
        [HttpGet("GetCommentByPost/{id}")]
        public IEnumerable<PostComment> GetCommentByPost(int id)
        {
            var list = new ViewPostAndComment();
            var comments = _IpostCommentService.GetAllPostCommentByPostID(id).ToList();
            if (comments != null)
            {
                foreach (var comment in comments)
                {
                    if (comment.PostID != 0)
                    {
                        yield return comment;
                    }
                }
            }
        }

        [HttpPost("CreateComment")]
        public ActionResult CreateComment([FromBody] PostComment postComment)
        {
            if (postComment == null)
            {
                return BadRequest();
            }
            else
            {
                postComment.Title = "a";
                postComment.CreateAT = DateTime.Now;
                postComment.PublishedAT = DateTime.Now;
                postComment.ParentID = 0;
                postComment.UserID = 2;

                //postComment.userID = _IaccountService.GetUserByEmail(User.Identity.Name).userID;
                _IpostCommentService.AddComment(postComment);
                _IpostCommentService.Save();
                return NoContent();
                /*return CreatedAtAction(nameof(GetCommentByPost), new { id = postComment.postCommentID }, postComment);*/
            }
        }
        [Authorize]
        [HttpPost("CreateSubComment")]
        public ActionResult CreateSubComment(PostComment postComment, int ID, int CommentID)
        {
            if (postComment == null)
            {
                return BadRequest();
            }
            else
            {
                postComment.PostID = ID;
                postComment.CreateAT = DateTime.Now;
                postComment.PublishedAT = DateTime.Now;
                //CommentID is ID postconment with parentID = 0;
                postComment.ParentID = CommentID;
                postComment.UserID = _IaccountService.GetUserByEmail(User.Identity.Name).UserID;
                _IpostCommentService.AddSubComment(postComment);
                _IpostCommentService.Save();
                return NoContent();
                /*return CreatedAtAction(nameof(GetCommentByPost), new { id = postComment.postCommentID }, postComment);*/
            }
        }
        [HttpDelete("DeleteComment/{id}")]
        public IActionResult DeleteComment(int id)
        {
            var a = _IpostCommentService.FindSubCommentInComment(id);
            if (a != null)
            {
                foreach (var item in a)
                {
                    _IpostCommentService.DeleteComment(item.PostID);
                    _IpostCommentService.Save();
                }
                _IpostCommentService.DeleteComment(id);
                _IpostCommentService.Save();
            }
            else
            {
                _IpostCommentService.DeleteComment(id);
                _IpostCommentService.Save();
            }
            return NoContent();
        }
        [HttpDelete("DeleteSubComment/{id}")]
        public IActionResult DeleteSubComment(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            _IpostCommentService.DeleteComment(id);
            _IpostCommentService.Save();
            return NoContent();
        }
    }
}
