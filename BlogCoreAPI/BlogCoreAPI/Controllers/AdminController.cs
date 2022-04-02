using DAL.Model;
using LOGIC.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCoreAPI.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly ILogger<AdminController> _logger;
        private IPostService _IpostService;
        private IAccountService _IaccountService;
        private IUserSevice _IuserService;
        public AdminController(ILogger<AdminController> logger, IUserSevice userSevice, IPostService postService, IAccountService accountService)
        {
            _logger = logger;
            this._IpostService = postService;
            this._IaccountService = accountService;
            this._IuserService = userSevice;
        }
/*        [Authorize(Roles = "admin")]*/
        [HttpGet("GetAllPost")]
        public IEnumerable<Post> GetAllPost()
        {
            var posts = _IpostService.GetAllPost();
            foreach (var post in posts)
            {
                if (post.PostID != 0)
                {
                    yield return post;
                }
            }
        }

        [HttpGet("GetPostById/{id}")]
        public IEnumerable<Post> GetPostById(int id)
        {
            var post = _IpostService.GetPostById(id);
            if (post != null)
            {
                yield return post;
            }
        }

        /// <summary>
        /// add new post with role admin  Must enter all post variable information except createAT
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        [HttpPost("CreatePost")]
        public ActionResult CreatePost([FromBody] Post post)
        {
            if (post == null)
            {
                return BadRequest();
            }
            else
            {
                post.CreateAT = DateTime.Now;
                post.PublishedAT = DateTime.Now;
                post.UpdateAT = DateTime.Now;
                _IpostService.AddNewPost(post);
                _IpostService.Save();
                return CreatedAtAction(nameof(GetPostById), new { id = post.PostID }, post);
            }
        }

        [HttpPut("UpdatePost/{id}")]
        public IActionResult UpdatePost(Post post, int id)
        {
            if (id != 0)
            {
                return BadRequest();
            }
            var valueUD = _IpostService.GetPostById(id);
            if (valueUD == null)
            {
                return NotFound();
            }
            _IpostService.UpdatePost(post);
            _IpostService.Save();
            return NoContent();
        }

        [HttpDelete("DeletePost")]
        public IActionResult DeletePost([FromBody] int id)
        {
            var todoItem = _IpostService.GetPostById(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            _IpostService.DeletePost(id);
            _IpostService.Save();

            return NoContent();
        }

        [HttpGet("GetAllUser")]
        public  IEnumerable<User> GetAllUser()
        {
            var users = _IuserService.GetAllUser();
            foreach (var user in users)
            {
                if (user.UserID != 0)
                {
                   yield return  user;
                }
            }
        }
        [HttpGet("GetUserById/{id}")]
        public IEnumerable<User> GetUserById(int id)
        {
            var user = _IuserService.GetUserById(id);
            if (user != null)
            {
                yield return user;
            }
        }
        [HttpPost("CreateUserItem")]
        public IActionResult CreateUserItem([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            else
            {
                user.LastLogin = DateTime.Now;
                user.Registered = DateTime.Now;
                _IuserService.AddNewUser(user);
                _IuserService.Save();
                /* return CreatedAtAction(nameof(GetUserById), new { id = user.userID }, user);*/
                return NoContent();
            }
        }

        [HttpPut("UpdateUser/{id}")]
        public IActionResult UpdateUser(int id, User user)
        {
            var valueUD = _IuserService.GetUserById(id);
            if (id != user.UserID)
            {
                return BadRequest();
            }
            if (valueUD == null)
            {
                return NotFound();
            }
            else
            {
                _IuserService.UpdateUser(user);
                _IuserService.Save();
                return NoContent();
            }
        }
        [HttpDelete("DeleteUser/{id}")]
        public IActionResult DeleteUser(int id)
        {
            var todoItem = _IuserService.GetUserById(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            _IuserService.DeleteUser(id);
            _IuserService.Save();

            return NoContent();
        }
    }
}
