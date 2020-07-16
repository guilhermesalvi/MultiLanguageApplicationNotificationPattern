using MultiLanguageApplication.Models;
using System.Threading.Tasks;

namespace MultiLanguageApplication.Services.Abstractions
{
    public interface IStudentService
    {
        Task<string> RegisterAsync(StudentInputModel model);
    }
}
