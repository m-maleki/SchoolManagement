using Core.Student.Contracts;
using Core.Student.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UI.Razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IStudentQueryServices _studentQueryServices;

        public IndexModel(IStudentQueryServices studentQueryServices)
        {
            _studentQueryServices = studentQueryServices;
        }

        public void OnGet()
        {
            //var model = new StudentAddDto
            //{
            //    FirstName = "hassan",
            //    LastName = "rezaei",
            //    Age = 25,
            //    PhoneNumber = "09121234567"
            //};

            //_studentQueryServices.Create(model);

            //var student = _studentQueryServices.Get(1);

            //_studentQueryServices.Delete(student.Id);

            //var students = _studentQueryServices.GetAll();

        }
    }
}