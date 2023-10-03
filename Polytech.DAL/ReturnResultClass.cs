using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polytech.DAL.Model;
namespace Polytech.DAL
{
    public class ReturnResult<T>
    {
        public bool IsError { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
        public T Data { get; set; }
        public List<T> ListData { get; set; }
    }
}
