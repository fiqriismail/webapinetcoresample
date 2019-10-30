using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWebAPI.Models
{
    public class ErrorModel
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public int ErrorNumber { get; set; }
    }
}
