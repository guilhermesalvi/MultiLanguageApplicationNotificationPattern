using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using MultiLanguageApplication.Notifications;
using System.Collections.Generic;

namespace MultiLanguageApplication.Controllers.Presenters
{
    public class PresenterBase
    {
        private readonly DomainNotificationHandler _domainNotification;
        private readonly IStringLocalizer<StudentController> _localizer;

        public bool IsValidOperation => !this._domainNotification.HasNotifications;
        public IActionResult Result { get; protected set; }

        public PresenterBase(INotificationHandler<DomainNotification> domainNotification,
                             IStringLocalizer<StudentController> localizer)
        {
            this._domainNotification = (DomainNotificationHandler)domainNotification;
            this._localizer = localizer;
        }

        public virtual void Populate(string message)
        {
            if (this.IsValidOperation)
            {
                this.Result = new OkObjectResult(new ResponseBase
                {
                    Succeeded = true,
                    Errors = null,
                    Message = this._localizer[message].Value
                });

                return;
            }

            this.Result = new UnprocessableEntityObjectResult(new ResponseBase
            {
                Succeeded = false,
                Errors = this.RenderErrorsWithLocalizer(),
                Message = null
            });
        }

        private IEnumerable<string> RenderErrorsWithLocalizer()
        {
            foreach (var notification in this._domainNotification.Notifications)
            {
                yield return this._localizer[notification.Message].Value;
            }
        }
    }
}
