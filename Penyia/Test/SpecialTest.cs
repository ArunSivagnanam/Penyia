using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Penyia.Models
{
    public class SpecialTest : Test
    {

        public SpecialTest()
            :base(5)
        {
            
        }


        public override void vMethod(string name)
        {
            base.vMethod(name);

            Debug.WriteLine("somthing new here");

        }
    }
}