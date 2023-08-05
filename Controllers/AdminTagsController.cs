// step 16: Create this AdminTags controller. It will let the Admin to perform CRUD operations

using BlogWebApp.Data;
using BlogWebApp.Models.Domain;
using BlogWebApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebApp.Controllers
{
    public class AdminTagsController : Controller
    {
        // step 26:
        private BlogDbContext _blogDbContext;


        // step 25: to access the service container we to do Contructor injection
        public AdminTagsController(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }


        // step 17: Create new Action method as Add and create its View

        [HttpGet]    //this get method is responsible for display the view after clicking Add
        public IActionResult Add()
        {
            return View();
        }

        // step 20: Create post method in order to capture the data which is coming after Submit button


        // step 24: Model will be coming as input parameter to this action method
        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {

            //step 25: mapping AddTagRequest to Tag domain model
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName,
            };

            _blogDbContext.Tags.Add(tag);

            return View("Add");
        }
    }
}
