using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SL_WCF
{
    public class ResultWCF
    {
        public bool Correct { get; set; }
        public string Mensaje { get; set; }
        public object Object { get; set; }
        public List<object> ObjectList { get; set; }
        public Exception Ex { get; set; }
    }
}