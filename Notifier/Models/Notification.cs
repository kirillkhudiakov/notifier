using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notifier.Models
{
    /// <summary>
    /// Encapsulates notification data.
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// Receiver user key.
        /// </summary>
        public string UserKey { get; set; }

        /// <summary>
        /// Message content.
        /// </summary>
        public string Message { get; set; }
    }
}
