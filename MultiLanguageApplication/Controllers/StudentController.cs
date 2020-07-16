using Microsoft.AspNetCore.Mvc;
using MultiLanguageApplication.Controllers.Presenters;
using MultiLanguageApplication.Models;
using MultiLanguageApplication.Services.Abstractions;
using System;
using System.Threading.Tasks;

namespace MultiLanguageApplication.Controllers
{
    [ApiController]
    [Route("api/student")]
    public class StudentController : ControllerBase
    {
        private readonly PresenterBase _presenter;
        private readonly IStudentService _service;

        public StudentController(PresenterBase presenter,
                                 IStudentService service)
        {
            this._presenter = presenter ?? throw new ArgumentNullException(nameof(presenter));
            this._service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpPost("")]
        public async Task<IActionResult> Register(StudentInputModel model)
        {
            this._presenter.Populate(await this._service.RegisterAsync(model));

            return this._presenter.Result;
        }
    }
}
