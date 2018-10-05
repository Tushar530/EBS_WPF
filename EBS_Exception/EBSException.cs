using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS_Exception
{ /// <summary>
  /// Author: Group3
  /// Handles all the exceptions in EBS
  /// </summary>
    public class EBSException :ApplicationException
    {
        public EBSException() : base() { }



        public EBSException(string errmessage) : base(errmessage) { }


    }
}
