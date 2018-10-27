using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJBException
{
    public class MJBException:ApplicationException
    {
        public MJBException() : base() { }

        public MJBException(string message) : base(message) { }

        public MJBException(string message, Exception innerException) : base(message, innerException) { }
    }
}
