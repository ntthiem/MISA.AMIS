using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Models
{
    public class ErrorMessenger
    {
        /// <summary>
        /// CreatedBy: NTTHIEM (21/22/2021)
        /// </summary>
        
        
        /// <summary>
        /// Thông báo cho Dev
        /// </summary>
        public string  DevMsg { get; set; }

        /// <summary>
        /// Thông báo cho người dùng
        /// </summary>
        public List<string> UserMsg { get; set; } = new List<String>();
        public string  ErrorCode { get; set; }
        public string MoreInfo { get; set; }
        public string TraceId { get; set; }
    }
}
