using MediatR;
using MultiLanguageApplication.Models;
using MultiLanguageApplication.Notifications;
using MultiLanguageApplication.Services.Abstractions;
using System.Threading.Tasks;

namespace MultiLanguageApplication.Services
{
    public class StudentService : IStudentService
    {
        private readonly IMediator _mediator;

        public StudentService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<string> RegisterAsync(StudentInputModel model)
        {
            if (model is null || model.Name is null)
            {
                await this._mediator.Publish(new DomainNotification("Null_Student_Name"));
                return default;
            }

            return "Student_Registered";
        }
    }
}
