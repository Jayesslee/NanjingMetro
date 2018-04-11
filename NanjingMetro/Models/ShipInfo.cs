using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NanjingMetro.Models
{
    public class ShipInfo
    {
        public StationInfo Curr { get; set; }
        public StationInfo Next { get; set; }

        public override string ToString()
        {
            return "Curr:" + Curr.Sid + "--Next:" + Next.Sid;
        }
    }
}