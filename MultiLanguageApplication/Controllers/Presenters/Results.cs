using System.Collections.Generic;

namespace MultiLanguageApplication.Controllers.Presenters
{
    public class ResponseBase
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
