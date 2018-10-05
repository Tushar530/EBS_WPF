using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS_Entities
{
    /// <summary>
    /// Author: Group3
    /// Travel class 
    /// </summary>
    public class Travel
    {
        public int TravelId { get; set; }

        public string SourceName { get; set; }

        public string DestinationName { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }
    }
}
