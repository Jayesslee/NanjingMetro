using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NanjingMetro.Models
{
    public class StationInfo
    {
        public int Lid { get; set; }
        public int Sid { get; set; }

        public override string ToString()
        {
            return "Sid:" + Sid + "--Lid:" + Lid;
        }
    }
}