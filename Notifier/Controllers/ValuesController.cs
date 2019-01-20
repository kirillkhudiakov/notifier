using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Notifier.Models;

namespace Notifier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendController : ControllerBase
    {
        const string AppToken = "ax9ks15s9ffgf86tqk9yc4oxkaeszg";

        /// <summary>
        /// Sends message to particular receiver.
        /// </summary>
        /// <param name="notification">Notification data</param>
        [HttpPost]
        public void PostSendMessage([FromBody] Notification notification)
        {
            var parameters = new NameValueCollection {
                { "token", AppToken },
                { "user", notification.UserKey },
                { "message", notification.Message }
            };

            using (var client = new WebClient())
            {
                client.UploadValues("https://api.pushover.net/1/messages.json", parameters);
            }
        }
    }
}
