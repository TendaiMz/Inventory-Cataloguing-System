
using HadwareInventorySystem.Core.Models;
using HadwareInventorySystem.Core.ViewModels;
using HadwareInventorySystem.Persistence;
using HadwareInventorySystem.Utilities;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace HadwareInventorySystem.Controllers
{
    public class ComponentsController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public ComponentsController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: Components
        public ActionResult Index()
        {
            var components = ObjectMapper.MapToModelList(_unitOfWork.Components.GetAllComponentsWithTypes().ToList());
            return View(components);
        }

        [HttpPost]
        public ActionResult Search(string searchCriteria)
        {

            if (ObjectMapper.MapToModelList(_unitOfWork.Components.GetFilteredComponentsWithTypes(searchCriteria).ToList()) != null)
            {
                return PartialView("_Components", ObjectMapper.MapToModelList(_unitOfWork.Components.GetFilteredComponentsWithTypes(searchCriteria).ToList()));

            }
            return PartialView("_Components", ObjectMapper.MapToModelList(_unitOfWork.Components.GetAllComponentsWithTypes().ToList()));
        }

        // GET: Components/Create
        public ActionResult Create()
        {
            ViewBag.Components = _unitOfWork.ComponentTypes.GetAll().ToList();
            return View();
        }

        // POST: Components/Create
        [HttpPost]
        public ActionResult Create(ComponentViewModel model)
        {
            try
            {
                var imageTypes = new string[]{
                    "image/gif",
                    "image/jpeg",
                    "image/pjpeg",
                    "image/png"
                };
                if (model.Image == null || model.Image.ContentLength == 0)
                {
                    ModelState.AddModelError("ImageUpload", "This field is required");
                }
                else if (!imageTypes.Contains(model.Image.ContentType))
                {
                    ModelState.AddModelError("ImageUpload", "Please choose either a GIF, JPG or PNG image.");
                }

                Component component = new Component();
                component.ComponentTypeId = model.ComponentTypeId;
                component.Description = model.Description;
                component.SerialNumber = model.SerialNumber;

                using (var binaryReader = new BinaryReader(model.Image.InputStream))
                    component.Photo = binaryReader.ReadBytes(model.Image.ContentLength);


                _unitOfWork.Components.Add(component);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Components = _unitOfWork.ComponentTypes.GetAll().ToList();
                return View();
            }
        }


    }
}
