using LatihanWebApi.Application.DefaultServices.StudentServices;
using LatihanWebApi.Application.DefaultServices.StudentServices.Dto;
using LatihanWebApi.Application.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;
using LatihanWebApi.Application.Model;

namespace LatihanWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentAppService _studentAppService;
        public StudentController(IStudentAppService studentAppService)
        {
            _studentAppService = studentAppService;
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody] CreateStudentDto model)
        {
            try
            {
                var (isAdded, message) = _studentAppService.CreateStudent(model);

                return Requests.Response(this, new ApiStatus(200), message, "Success");
            }
            catch(DbException de)
            {
                return Requests.Response(this, new ApiStatus(500), null, de.Message);

            }
        }
    }
}
