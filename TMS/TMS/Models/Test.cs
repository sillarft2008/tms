using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMS.Models
{
    public class Test
    {
        public String name { get; set; }
        public String[] task { get; set; }

        public Test() {
            task = new String[16];
        }

    }
}