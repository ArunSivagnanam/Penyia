using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Web;

namespace Penyia.Models
{
    public class Test
    {

        // props

        private string name;

        private string age;

        public string dog;

        public string cat;

        public const double PI = 3.1;

        public readonly string nizle;

        public string Address { get; set; }


        // Constructor chained 

        public Test(int number)
            :this(number,"")
        {
            nizle = "nizle";
            Debug.WriteLine("chained constructor called");
        }


        public Test(int number, string name)
        {

            Debug.WriteLine("chained constructor working here");
            
        }

        // optional arguments
        public void optional(int number, string name = "hello there")
        {
            
            Debug.Write("the optional value is "+name);
        }


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        public virtual void vMethod(String name)
        {
            Debug.WriteLine("bobo is nice");
        }


    }
}